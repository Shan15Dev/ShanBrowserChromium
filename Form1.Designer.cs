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
            this.chromium = new System.Windows.Forms.Panel();
            this.urlField = new MetroFramework.Controls.MetroTextBox();
            this.search_btn = new MetroFramework.Controls.MetroButton();
            this.forward_btn = new MetroFramework.Controls.MetroButton();
            this.back_btn = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // chromium
            // 
            this.chromium.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.chromium.Location = new System.Drawing.Point(0, 39);
            this.chromium.Name = "chromium";
            this.chromium.Size = new System.Drawing.Size(807, 415);
            this.chromium.TabIndex = 2;
            this.chromium.Paint += new System.Windows.Forms.PaintEventHandler(this.chromium_Paint);
            // 
            // urlField
            // 
            this.urlField.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.urlField.Location = new System.Drawing.Point(82, 5);
            this.urlField.Name = "urlField";
            this.urlField.Size = new System.Drawing.Size(625, 23);
            this.urlField.TabIndex = 3;
            this.urlField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.urlField_KeyUp);
            // 
            // search_btn
            // 
            this.search_btn.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.search_btn.Location = new System.Drawing.Point(713, 5);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "Search";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // forward_btn
            // 
            this.forward_btn.Location = new System.Drawing.Point(52, 5);
            this.forward_btn.Name = "forward_btn";
            this.forward_btn.Size = new System.Drawing.Size(24, 23);
            this.forward_btn.TabIndex = 5;
            this.forward_btn.Text = "->";
            this.forward_btn.Click += new System.EventHandler(this.forward_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(22, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(24, 23);
            this.back_btn.TabIndex = 6;
            this.back_btn.Text = "<-";
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.forward_btn);
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
        private MetroFramework.Controls.MetroButton forward_btn;
        private MetroFramework.Controls.MetroButton back_btn;
    }
}

