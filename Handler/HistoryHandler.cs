using System.IO;
using System.Windows.Forms;
using Microsoft.Win32;

namespace ShanBrowserChromium.Handler
{
    public class HistoryHandler
    {
        private const string _fileName = @"C:\Data\ShanBrowser\HistoryText.txt";
        private const string _directory = @"C:\Data\ShanBrowser";
        private int menuCounter = 0;

        public void CreateDirectory()
        {
            if (!Directory.Exists(_directory))
            {
                Directory.CreateDirectory(_directory);
            }
            else if (!File.Exists(_fileName))
            {
                File.Create(_fileName);
            }
        }
        

        public void InsertIntoHistory(string url)
        {
            using (StreamWriter sw = File.AppendText(_fileName))
            {
                sw.WriteLine(url);
            }
        }

        public void CheckHistory()
        {
            using (StreamReader sr = File.OpenText(_fileName))
            {
                while (sr != null)
                {
                    
                }
            }
        }
    }
}