using System.ComponentModel;

namespace LB_2
{
    partial class UseVpnView
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
            this.tbMegabytes = new System.Windows.Forms.TextBox();
            this.btUseVpn = new System.Windows.Forms.Button();
            this.lMegabytes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMegabytes
            // 
            this.tbMegabytes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMegabytes.Location = new System.Drawing.Point(113, 16);
            this.tbMegabytes.Name = "tbMegabytes";
            this.tbMegabytes.Size = new System.Drawing.Size(134, 22);
            this.tbMegabytes.TabIndex = 0;
            // 
            // btUseVpn
            // 
            this.btUseVpn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btUseVpn.Location = new System.Drawing.Point(18, 45);
            this.btUseVpn.Name = "btUseVpn";
            this.btUseVpn.Size = new System.Drawing.Size(229, 24);
            this.btUseVpn.TabIndex = 1;
            this.btUseVpn.Text = "Use VPN";
            this.btUseVpn.UseVisualStyleBackColor = true;
            this.btUseVpn.Click += new System.EventHandler(this.btUseVpn_Click);
            // 
            // lMegabytes
            // 
            this.lMegabytes.Location = new System.Drawing.Point(18, 16);
            this.lMegabytes.Name = "lMegabytes";
            this.lMegabytes.Size = new System.Drawing.Size(89, 21);
            this.lMegabytes.TabIndex = 2;
            this.lMegabytes.Text = "Megabytes";
            // 
            // UseVpnView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 81);
            this.Controls.Add(this.lMegabytes);
            this.Controls.Add(this.btUseVpn);
            this.Controls.Add(this.tbMegabytes);
            this.Name = "UseVpnView";
            this.Text = "UseVpnView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lMegabytes;

        private System.Windows.Forms.TextBox tbMegabytes;
        private System.Windows.Forms.Button btUseVpn;

        #endregion
    }
}