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
            this.chromium = new System.Windows.Forms.Panel();
            this.urlField = new MetroFramework.Controls.MetroTextBox();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.forward_btn = new MetroFramework.Controls.MetroButton();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chromium
            // 
            resources.ApplyResources(this.chromium, "chromium");
            this.chromium.Name = "chromium";
            this.chromium.Paint += new System.Windows.Forms.PaintEventHandler(this.chromium_Paint);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
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
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.forward_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.urlField);
            this.Controls.Add(this.chromium);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;

        #endregion
        private System.Windows.Forms.Panel chromium;
        private MetroFramework.Controls.MetroTextBox urlField;
        private MetroFramework.Controls.MetroButton search_btn;
        private MetroFramework.Controls.MetroButton forward_btn;
        private MetroFramework.Controls.MetroButton back_btn;
    }
}

