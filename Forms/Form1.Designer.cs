namespace ShanBrowserChromium
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.urlField = new MetroFramework.Controls.MetroTextBox();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.forward_btn = new MetroFramework.Controls.MetroButton();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.miniToolStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addTab = new MetroFramework.Controls.MetroButton();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chromium = new System.Windows.Forms.Panel();
            this.miniToolStrip.SuspendLayout();
            this.tabs.SuspendLayout();
            this.chromium.SuspendLayout();
            this.SuspendLayout();
            // 
            // urlField
            // 
            resources.ApplyResources(this.urlField, "urlField");
            this.urlField.Name = "urlField";
            this.urlField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlField_KeyUp);
            // 
            // search_btn
            // 
            resources.ApplyResources(this.search_btn, "search_btn");
            this.search_btn.Name = "search_btn";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // forward_btn
            // 
            resources.ApplyResources(this.forward_btn, "forward_btn");
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // back_btn
            // 
            resources.ApplyResources(this.back_btn, "back_btn");
            this.back_btn.Name = "back_btn";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            resources.ApplyResources(this.miniToolStrip, "miniToolStrip");
            this.miniToolStrip.Name = "miniToolStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            resources.ApplyResources(this.settingsToolStripMenuItem, "settingsToolStripMenuItem");
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // addTab
            // 
            resources.ApplyResources(this.addTab, "addTab");
            this.addTab.Name = "addTab";
            this.addTab.Click += new System.EventHandler(this.AddTab_KeyPress);
            // 
            // tabs
            // 
            resources.ApplyResources(this.tabs, "tabs");
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.SelectedIndexChanged += new System.EventHandler(this.tabs_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // chromium
            // 
            resources.ApplyResources(this.chromium, "chromium");
            this.chromium.Controls.Add(this.tabs);
            this.chromium.Name = "chromium";
            this.chromium.Paint += new System.Windows.Forms.PaintEventHandler(this.chromium_Paint);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.addTab);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.urlField);
            this.Controls.Add(this.chromium);
            this.Controls.Add(this.miniToolStrip);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlField_KeyUp);
            this.miniToolStrip.ResumeLayout(false);
            this.miniToolStrip.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.chromium.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TabPage tabPage1;

        private MetroFramework.Controls.MetroButton addTab;

        private MetroFramework.Controls.MetroTabControl tabs;

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private System.Windows.Forms.MenuStrip miniToolStrip;

        #endregion
        private System.Windows.Forms.Panel chromium;
        private MetroFramework.Controls.MetroTextBox urlField;
        private MetroFramework.Controls.MetroButton search_btn;
        private MetroFramework.Controls.MetroButton forward_btn;
        private MetroFramework.Controls.MetroButton back_btn;
    }
}

