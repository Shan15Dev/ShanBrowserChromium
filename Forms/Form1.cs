﻿using CefSharp;
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
        public CefSharp.WinForms.ChromiumWebBrowser browser =
            new CefSharp.WinForms.ChromiumWebBrowser("https://google.ch");

        private Handler.UrlHandler _urlHandler = new Handler.UrlHandler();

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
            urlField.Text = browser.Address;
        }

        private void chromium_Paint(object sender, PaintEventArgs e)
        {
            this.chromium.Controls.Add(browser);
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
                browser.Load(_urlHandler._url);
            }
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Settings settings = new Settings();
            }
            catch (Exception exception)
            {
                throw new Exception();
            }
        }
    }
}