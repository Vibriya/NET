using System.ComponentModel;

namespace LB_2
{
    partial class AddMoneyView
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
            this.tbMoney = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.lMoney = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbMoney
            // 
            this.tbMoney.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMoney.Location = new System.Drawing.Point(95, 12);
            this.tbMoney.Name = "tbMoney";
            this.tbMoney.Size = new System.Drawing.Size(168, 22);
            this.tbMoney.TabIndex = 0;
            // 
            // btAdd
            // 
            this.btAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btAdd.Location = new System.Drawing.Point(12, 46);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(251, 27);
            this.btAdd.TabIndex = 1;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lMoney
            // 
            this.lMoney.Location = new System.Drawing.Point(12, 12);
            this.lMoney.Name = "lMoney";
            this.lMoney.Size = new System.Drawing.Size(77, 22);
            this.lMoney.TabIndex = 2;
            this.lMoney.Text = "Money";
            // 
            // AddMoneyView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 85);
            this.Controls.Add(this.lMoney);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbMoney);
            this.Name = "AddMoneyView";
            this.Text = "AddMoneyView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lMoney;

        private System.Windows.Forms.TextBox tbMoney;
        private System.Windows.Forms.Button btAdd;

        #endregion
    }
}