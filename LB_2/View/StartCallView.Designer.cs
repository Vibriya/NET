using System.ComponentModel;

namespace LB_2
{
    partial class StartCallView
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
            this.tbToNumber = new System.Windows.Forms.TextBox();
            this.btCall = new System.Windows.Forms.Button();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbToNumber
            // 
            this.tbToNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbToNumber.Location = new System.Drawing.Point(103, 34);
            this.tbToNumber.Name = "tbToNumber";
            this.tbToNumber.Size = new System.Drawing.Size(142, 22);
            this.tbToNumber.TabIndex = 0;
            // 
            // btCall
            // 
            this.btCall.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btCall.Location = new System.Drawing.Point(12, 62);
            this.btCall.Name = "btCall";
            this.btCall.Size = new System.Drawing.Size(232, 30);
            this.btCall.TabIndex = 1;
            this.btCall.Text = "Call";
            this.btCall.UseVisualStyleBackColor = true;
            this.btCall.Click += new System.EventHandler(this.btCall_Click);
            // 
            // tbMinutes
            // 
            this.tbMinutes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinutes.Location = new System.Drawing.Point(103, 6);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.Size = new System.Drawing.Size(141, 22);
            this.tbMinutes.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Minutes";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "To Number";
            // 
            // StartCallView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 101);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMinutes);
            this.Controls.Add(this.btCall);
            this.Controls.Add(this.tbToNumber);
            this.Name = "StartCallView";
            this.Text = "Input Number";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox tbMinutes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.TextBox tbToNumber;
        private System.Windows.Forms.Button btCall;

        #endregion
    }
}