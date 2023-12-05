using System.ComponentModel;

namespace LB_2
{
    partial class CallHistoryView
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
            this.lbCallHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lbCallHistory
            // 
            this.lbCallHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbCallHistory.FormattingEnabled = true;
            this.lbCallHistory.ItemHeight = 16;
            this.lbCallHistory.Location = new System.Drawing.Point(8, 9);
            this.lbCallHistory.Name = "lbCallHistory";
            this.lbCallHistory.Size = new System.Drawing.Size(412, 292);
            this.lbCallHistory.TabIndex = 0;
            // 
            // CallHistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 311);
            this.Controls.Add(this.lbCallHistory);
            this.Name = "CallHistoryView";
            this.Text = "CallHistoryView";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox lbCallHistory;

        #endregion
    }
}