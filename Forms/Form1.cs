using CefSharp;
using System;
using System.Collections;
using System.Windows.Forms;
using MetroFramework.Controls;
using ShanBrowserChromium.Handler;

namespace ShanBrowserChromium
{
    public partial class Form1 : Form
    {
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private int tabCounter = 2;

        private UrlHandler _urlHandler = new UrlHandler();

        private SearchMachineHandler _searchMachineHandler = new SearchMachineHandler();

        private HistoryHandler _historyHandler = new HistoryHandler();



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _searchMachineHandler.CreateDirectory();
            _historyHandler.CreateDirectory();
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
            tabPage1.Controls.Add(browser);
            tabPage1.Text = "Welcome";
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

        private void AddTab_KeyPress(object sender, EventArgs e)
        {
            MetroTabPage metroTabPage = new MetroTabPage();
            metroTabPage.Text = "Welcome";
            tabs.Controls.Add(metroTabPage);
            CefSharp.WinForms.ChromiumWebBrowser chromiumWebBrowser =
                new CefSharp.WinForms.ChromiumWebBrowser(_searchMachineHandler.CheckSearchMachine());
            chromiumWebBrowser.Parent = tabs;
            chromiumWebBrowser.Dock = DockStyle.Fill;

        }

        private void tabs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
    }
}