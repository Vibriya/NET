using System.ComponentModel;

namespace LB_2
{
    partial class NewOperatorView
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.Label();
            this.cbTariff = new System.Windows.Forms.ComboBox();
            this.lTariff = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbPaid = new System.Windows.Forms.CheckBox();
            this.cbRoaming = new System.Windows.Forms.CheckBox();
            this.tbAccount = new System.Windows.Forms.TextBox();
            this.tbNumber = new System.Windows.Forms.TextBox();
            this.btCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(104, 22);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(201, 22);
            this.tbName.TabIndex = 0;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(15, 22);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(81, 23);
            this.lName.TabIndex = 1;
            this.lName.Text = "Name";
            // 
            // cbTariff
            // 
            this.cbTariff.FormattingEnabled = true;
            this.cbTariff.Items.AddRange(new object[] { "Starter", "Max", "Pro", "Turbo" });
            this.cbTariff.Location = new System.Drawing.Point(105, 52);
            this.cbTariff.Name = "cbTariff";
            this.cbTariff.Size = new System.Drawing.Size(200, 24);
            this.cbTariff.TabIndex = 2;
            // 
            // lTariff
            // 
            this.lTariff.Location = new System.Drawing.Point(15, 52);
            this.lTariff.Name = "lTariff";
            this.lTariff.Size = new System.Drawing.Size(81, 23);
            this.lTariff.TabIndex = 3;
            this.lTariff.Text = "Tariff";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "Account";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(15, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Number";
            // 
            // cbPaid
            // 
            this.cbPaid.Location = new System.Drawing.Point(107, 90);
            this.cbPaid.Name = "cbPaid";
            this.cbPaid.Size = new System.Drawing.Size(139, 20);
            this.cbPaid.TabIndex = 8;
            this.cbPaid.Text = "Paid";
            this.cbPaid.UseVisualStyleBackColor = true;
            // 
            // cbRoaming
            // 
            this.cbRoaming.Location = new System.Drawing.Point(107, 121);
            this.cbRoaming.Name = "cbRoaming";
            this.cbRoaming.Size = new System.Drawing.Size(140, 22);
            this.cbRoaming.TabIndex = 9;
            this.cbRoaming.Text = "Roaming";
            this.cbRoaming.UseVisualStyleBackColor = true;
            // 
            // tbAccount
            // 
            this.tbAccount.Location = new System.Drawing.Point(105, 149);
            this.tbAccount.Name = "tbAccount";
            this.tbAccount.Size = new System.Drawing.Size(200, 22);
            this.tbAccount.TabIndex = 10;
            this.tbAccount.UseWaitCursor = true;
            // 
            // tbNumber
            // 
            this.tbNumber.Location = new System.Drawing.Point(105, 180);
            this.tbNumber.Name = "tbNumber";
            this.tbNumber.Size = new System.Drawing.Size(200, 22);
            this.tbNumber.TabIndex = 11;
            // 
            // btCreate
            // 
            this.btCreate.Location = new System.Drawing.Point(12, 224);
            this.btCreate.Name = "btCreate";
            this.btCreate.Size = new System.Drawing.Size(296, 31);
            this.btCreate.TabIndex = 12;
            this.btCreate.Text = "Create";
            this.btCreate.UseVisualStyleBackColor = true;
            this.btCreate.Click += new System.EventHandler(this.btCreate_Click);
            // 
            // NewOperatorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 262);
            this.Controls.Add(this.btCreate);
            this.Controls.Add(this.tbNumber);
            this.Controls.Add(this.tbAccount);
            this.Controls.Add(this.cbRoaming);
            this.Controls.Add(this.cbPaid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lTariff);
            this.Controls.Add(this.cbTariff);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.tbName);
            this.Name = "NewOperatorView";
            this.Text = "NewOperatorView";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbPaid;
        private System.Windows.Forms.CheckBox cbRoaming;
        private System.Windows.Forms.TextBox tbAccount;
        private System.Windows.Forms.TextBox tbNumber;
        private System.Windows.Forms.Button btCreate;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label lTariff;

        private System.Windows.Forms.ComboBox cbTariff;

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label lName;

        #endregion
    }
}