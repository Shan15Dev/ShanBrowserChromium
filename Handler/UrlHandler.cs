using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShanBrowserChromium.Handler
{
    public class UrlHandler
    {
        public string _url { get; set; }

        public void ControlUrl(string url)
        {
            if (url.Contains("https://www."))
            {
                _url = url;
            }
            else if(url.Contains("www.") && !url.Contains("https://"))
            {
                _url = "https://" + url;
            }
            else if (url.Contains("."))
            {
                _url = "https://www." + url;
            }
        }
    }
}
