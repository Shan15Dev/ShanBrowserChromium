using System;
using System.Diagnostics;
using System.IO;

namespace ShanBrowserChromium.Handler
{
    public class SearchMachineHandler
    {
        private const string _fileName = @"C:\Data\ShanBrowser\SearchEngine.txt";
        private const string _directory = @"C:\Data\ShanBrowser";

        public void CreateDirectory()
        {
            if (!Directory.Exists(_directory) && !File.Exists(_fileName))
            {
                Directory.CreateDirectory(_directory);
                ChangeSearchMachine("Google");
            }
        }
        public void ChangeSearchMachine(string searchEngine)
        {

            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            
            // Create the File
            using (StreamWriter sw = File.CreateText(_fileName))
            {
                switch (searchEngine)
                {
                    case "Google":
                        sw.WriteLine("https://www.google.ch/search?q=");
                        break;
                    case "Bing":
                        sw.WriteLine("https://www.bing.com/search?q=");
                        break;
                    case "Ecosia":
                        sw.WriteLine("https://www.ecosia.org/search?q=");
                        break;
                    case "DuckDuckGo":
                        sw.WriteLine("https://duckduckgo.com/?q=");
                        break;
                    case "Yahoo":
                        sw.WriteLine("https://search.yahoo.com/search?p=");
                        break;
                }
            }
        }

        public string CheckSearchMachine()
        {
            using (StreamReader sr = File.OpenText(_fileName))
            {
                string searchEngineText;
                searchEngineText = sr.ReadLine();
                return searchEngineText;
            }
            
        }
    }
}