using CefSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ShanBrowserChromium.Handler;

namespace ShanBrowserChromium
{
    public partial class Form1 : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private Handler.UrlHandler _urlHandler = new Handler.UrlHandler();

        private SearchMachineHandler _searchMachineHandler = new SearchMachineHandler();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _searchMachineHandler.CreateDirectory();
            browser = new CefSharp.WinForms.ChromiumWebBrowser(_searchMachineHandler.CheckSearchMachine());
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            _urlHandler.ControlUrl(urlField.Text);
            browser.Load(_urlHandler.Url);
            urlField.Text = browser.Address;
        }

        private void chromium_Paint(object sender, PaintEventArgs e)
        {
            this.chromium.Controls.Add(browser);
            urlField.Text = browser.Address;
        }


        private void back_btn_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
            {
                browser.Back();
                urlField.Text = browser.Address;
            }
        }

        private void forward_btn_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
            {
                browser.Forward();
                urlField.Text = browser.Address;
            }
        }

        private void urlField_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _urlHandler.ControlUrl(urlField.Text);
                browser.Load(_urlHandler.Url);
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Settings settings = new Settings();
                settings.Show();
            }
            catch (Exception exception)
            {
                throw new Exception();
            }
        }
    }
}