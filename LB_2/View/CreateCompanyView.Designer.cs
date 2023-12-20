using System.ComponentModel;

namespace LB_2
{
    partial class CreateCompanyView
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
            this.btCreateCompany = new System.Windows.Forms.Button();
            this.tbCompanyName = new System.Windows.Forms.TextBox();
            this.tbEDRPOY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btCreateCompany
            // 
            this.btCreateCompany.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btCreateCompany.Location = new System.Drawing.Point(12, 90);
            this.btCreateCompany.Name = "btCreateCompany";
            this.btCreateCompany.Size = new System.Drawing.Size(349, 36);
            this.btCreateCompany.TabIndex = 0;
            this.btCreateCompany.Text = "Create Company";
            this.btCreateCompany.UseVisualStyleBackColor = true;
            this.btCreateCompany.Click += new System.EventHandler(this.btCreateCompany_Click);
            // 
            // tbCompanyName
            // 
            this.tbCompanyName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCompanyName.Location = new System.Drawing.Point(93, 25);
            this.tbCompanyName.Name = "tbCompanyName";
            this.tbCompanyName.Size = new System.Drawing.Size(268, 22);
            this.tbCompanyName.TabIndex = 1;
            // 
            // tbEDRPOY
            // 
            this.tbEDRPOY.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbEDRPOY.Location = new System.Drawing.Point(93, 62);
            this.tbEDRPOY.Name = "tbEDRPOY";
            this.tbEDRPOY.Size = new System.Drawing.Size(268, 22);
            this.tbEDRPOY.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "EDRPOY";
            // 
            // CreateCompanyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 143);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbEDRPOY);
            this.Controls.Add(this.tbCompanyName);
            this.Controls.Add(this.btCreateCompany);
            this.Name = "CreateCompanyView";
            this.Text = "CreateCompanyView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbEDRPOY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Button btCreateCompany;
        private System.Windows.Forms.TextBox tbCompanyName;

        #endregion
    }
}