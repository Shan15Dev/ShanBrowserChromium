﻿using System;
using System.Windows.Forms;
using ShanBrowserChromium.Handler;

namespace ShanBrowserChromium
{
    public partial class Settings : Form
    {
        private string _searchEngineSelected;
        private SearchMachineHandler _searchMachineHandler = new SearchMachineHandler();

        public Settings()
        {
            InitializeComponent();
        }

        private void SearchEngineCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _searchEngineSelected = SearchEngineCombobox.SelectedItem.ToString();
            _searchMachineHandler.ChangeSearchMachine(_searchEngineSelected);
        }
    }
}