using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShanBrowserChromium
{
    public partial class Form1 : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser browser = new CefSharp.WinForms.ChromiumWebBrowser("https://google.ch");
        private Handler.UrlHandler _urlHandler = new Handler.UrlHandler();
        private bool _isClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            _urlHandler.ControlUrl(urlField.Text);
            browser.Load(_urlHandler._url);
        }

        private void chromium_Paint(object sender, PaintEventArgs e)
        {
            this.chromium.Controls.Add(browser);
        }


        private void urlField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_isClicked)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    _urlHandler.ControlUrl(urlField.Text);
                    browser.Load(_urlHandler._url);
                    _isClicked = false;
                }
            }
        }

        private void urlField_Click(object sender, MouseEventArgs e)
        {
            _isClicked = true;
        }
    }
}
