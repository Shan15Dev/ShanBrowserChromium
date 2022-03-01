using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShanBrowserChromium.Handler
{
    public class UrlHandler
    {
        public string Url { get; set; }
        private string _searchEngine;
        private SearchMachineHandler _searchMachineHandler = new SearchMachineHandler();
        private HistoryHandler _historyHandler = new HistoryHandler();

        public void ControlUrl(string url)
        {
            if (url.Contains("https://www."))
            {
                Url = url;
            }
            else if (url.Contains("http://"))
            {
                Url = url;
            }
            else if (url.Contains("www.") && !url.Contains("https://"))
            {
                Url = "https://" + url;
            }
            else if (url.Contains("."))
            {
                Url = "https://www." + url;
            }
            else
            {
                _searchEngine = _searchMachineHandler.CheckSearchMachine();
                Url = _searchEngine + url;
            }
            
            _historyHandler.InsertIntoHistory(Url);
        }
    }
}