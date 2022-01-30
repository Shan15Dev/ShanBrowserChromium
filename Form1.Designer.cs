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
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.chromium = new System.Windows.Forms.Panel();
            this.urlField = new MetroFramework.Controls.MetroTextBox();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // chromium
            // 
            this.chromium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chromium.Location = new System.Drawing.Point(0, 39);
            this.chromium.Name = "chromium";
            this.chromium.Size = new System.Drawing.Size(807, 415);
            this.chromium.TabIndex = 2;
            this.chromium.Paint += new System.Windows.Forms.PaintEventHandler(this.chromium_Paint);
            // 
            // urlField
            // 
            this.urlField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.urlField.Location = new System.Drawing.Point(61, 5);
            this.urlField.Name = "urlField";
            this.urlField.Size = new System.Drawing.Size(625, 23);
            this.urlField.TabIndex = 3;
            this.urlField.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.urlField_KeyPress);
            this.urlField.MouseClick += new System.Windows.Forms.MouseEventHandler(this.urlField_Click);
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.Location = new System.Drawing.Point(713, 5);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.urlField);
            this.Controls.Add(this.chromium);
            this.Name = "Form1";
            this.Text = "ShanBrowser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel chromium;
        private MetroFramework.Controls.MetroTextBox urlField;
        private MetroFramework.Controls.MetroButton search_btn;
    }
}

