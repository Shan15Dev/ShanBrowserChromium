using System.ComponentModel;

namespace ShanBrowserChromium
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SettingsTitleLabe = new MetroFramework.Controls.MetroLabel();
            this.SearchEngineLabel = new MetroFramework.Controls.MetroLabel();
            this.SearchEngineCombobox = new MetroFramework.Controls.MetroComboBox();
            this.SuspendLayout();
            // 
            // SettingsTitleLabe
            // 
            this.SettingsTitleLabe.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SettingsTitleLabe.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SettingsTitleLabe.Location = new System.Drawing.Point(12, 10);
            this.SettingsTitleLabe.Name = "SettingsTitleLabe";
            this.SettingsTitleLabe.Size = new System.Drawing.Size(143, 35);
            this.SettingsTitleLabe.TabIndex = 0;
            this.SettingsTitleLabe.Text = "Settings:";
            // 
            // SearchEngineLabel
            // 
            this.SearchEngineLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SearchEngineLabel.Location = new System.Drawing.Point(42, 47);
            this.SearchEngineLabel.Name = "SearchEngineLabel";
            this.SearchEngineLabel.Size = new System.Drawing.Size(112, 28);
            this.SearchEngineLabel.TabIndex = 1;
            this.SearchEngineLabel.Text = "Search Engine:";
            // 
            // SearchEngineCombobox
            // 
            this.SearchEngineCombobox.FormattingEnabled = true;
            this.SearchEngineCombobox.ItemHeight = 23;
            this.SearchEngineCombobox.Items.AddRange(new object[] {"Google", "Bing", "Ecosia", "DuckDuckGo", "Yahoo"});
            this.SearchEngineCombobox.Location = new System.Drawing.Point(161, 46);
            this.SearchEngineCombobox.Name = "SearchEngineCombobox";
            this.SearchEngineCombobox.Size = new System.Drawing.Size(162, 29);
            this.SearchEngineCombobox.TabIndex = 2;
            this.SearchEngineCombobox.SelectedIndexChanged += new System.EventHandler(this.SearchEngineCombobox_SelectedIndexChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SearchEngineCombobox);
            this.Controls.Add(this.SearchEngineLabel);
            this.Controls.Add(this.SettingsTitleLabe);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
        }

        private MetroFramework.Controls.MetroComboBox SearchEngineCombobox;

        private MetroFramework.Controls.MetroLabel SearchEngineLabel;

        private MetroFramework.Controls.MetroLabel SettingsTitleLabe;

        #endregion
    }
}