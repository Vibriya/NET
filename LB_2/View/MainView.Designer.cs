namespace LB_2
{
    partial class MainView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btChangeTariff = new System.Windows.Forms.Button();
            this.btStartCall = new System.Windows.Forms.Button();
            this.btAddMoney = new System.Windows.Forms.Button();
            this.btUseVpn = new System.Windows.Forms.Button();
            this.btAddOperator = new System.Windows.Forms.Button();
            this.btDelOperator = new System.Windows.Forms.Button();
            this.btShowCallHistory = new System.Windows.Forms.Button();
            this.dgOperatorGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgOperatorGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btChangeTariff
            // 
            this.btChangeTariff.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btChangeTariff.Location = new System.Drawing.Point(814, 54);
            this.btChangeTariff.Name = "btChangeTariff";
            this.btChangeTariff.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btChangeTariff.Size = new System.Drawing.Size(151, 36);
            this.btChangeTariff.TabIndex = 0;
            this.btChangeTariff.Text = "ChangeTariff";
            this.btChangeTariff.UseVisualStyleBackColor = true;
            this.btChangeTariff.Click += new System.EventHandler(this.btChangeTariff_Click);
            // 
            // btStartCall
            // 
            this.btStartCall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btStartCall.Location = new System.Drawing.Point(814, 12);
            this.btStartCall.Name = "btStartCall";
            this.btStartCall.Size = new System.Drawing.Size(151, 36);
            this.btStartCall.TabIndex = 2;
            this.btStartCall.Text = "StartCall";
            this.btStartCall.UseVisualStyleBackColor = true;
            this.btStartCall.Click += new System.EventHandler(this.btStartCall_Click);
            // 
            // btAddMoney
            // 
            this.btAddMoney.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btAddMoney.Location = new System.Drawing.Point(814, 96);
            this.btAddMoney.Name = "btAddMoney";
            this.btAddMoney.Size = new System.Drawing.Size(151, 34);
            this.btAddMoney.TabIndex = 3;
            this.btAddMoney.Text = "AddMoney";
            this.btAddMoney.UseVisualStyleBackColor = true;
            this.btAddMoney.Click += new System.EventHandler(this.btAddMoney_Click);
            // 
            // btUseVpn
            // 
            this.btUseVpn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btUseVpn.Location = new System.Drawing.Point(814, 136);
            this.btUseVpn.Name = "btUseVpn";
            this.btUseVpn.Size = new System.Drawing.Size(153, 33);
            this.btUseVpn.TabIndex = 5;
            this.btUseVpn.Text = "UseVpn";
            this.btUseVpn.UseVisualStyleBackColor = true;
            this.btUseVpn.Click += new System.EventHandler(this.btUseVpn_Click);
            // 
            // btAddOperator
            // 
            this.btAddOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btAddOperator.Location = new System.Drawing.Point(12, 279);
            this.btAddOperator.Name = "btAddOperator";
            this.btAddOperator.Size = new System.Drawing.Size(183, 34);
            this.btAddOperator.TabIndex = 6;
            this.btAddOperator.Text = "Add";
            this.btAddOperator.UseVisualStyleBackColor = true;
            this.btAddOperator.Click += new System.EventHandler(this.btAddOperator_Click);
            // 
            // btDelOperator
            // 
            this.btDelOperator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btDelOperator.Location = new System.Drawing.Point(628, 279);
            this.btDelOperator.Name = "btDelOperator";
            this.btDelOperator.Size = new System.Drawing.Size(180, 34);
            this.btDelOperator.TabIndex = 7;
            this.btDelOperator.Text = "Delete";
            this.btDelOperator.UseVisualStyleBackColor = true;
            this.btDelOperator.Click += new System.EventHandler(this.btDelOperator_Click);
            // 
            // btShowCallHistory
            // 
            this.btShowCallHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btShowCallHistory.Location = new System.Drawing.Point(814, 175);
            this.btShowCallHistory.Name = "btShowCallHistory";
            this.btShowCallHistory.Size = new System.Drawing.Size(150, 31);
            this.btShowCallHistory.TabIndex = 8;
            this.btShowCallHistory.Text = "Show Call History";
            this.btShowCallHistory.UseVisualStyleBackColor = true;
            this.btShowCallHistory.Click += new System.EventHandler(this.btShowCallHistory_Click);
            // 
            // dgOperatorGrid
            // 
            this.dgOperatorGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dgOperatorGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOperatorGrid.Location = new System.Drawing.Point(12, 12);
            this.dgOperatorGrid.Name = "dgOperatorGrid";
            this.dgOperatorGrid.RowTemplate.Height = 24;
            this.dgOperatorGrid.Size = new System.Drawing.Size(796, 253);
            this.dgOperatorGrid.TabIndex = 9;
            this.dgOperatorGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgOperatorGrid_CellFormatting);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 325);
            this.Controls.Add(this.dgOperatorGrid);
            this.Controls.Add(this.btShowCallHistory);
            this.Controls.Add(this.btDelOperator);
            this.Controls.Add(this.btAddOperator);
            this.Controls.Add(this.btUseVpn);
            this.Controls.Add(this.btAddMoney);
            this.Controls.Add(this.btStartCall);
            this.Controls.Add(this.btChangeTariff);
            this.Name = "MainView";
            this.Text = "MainView";
            ((System.ComponentModel.ISupportInitialize)(this.dgOperatorGrid)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridView dgOperatorGrid;

        private System.Windows.Forms.Button btShowCallHistory;

        private System.Windows.Forms.Button btAddOperator;
        private System.Windows.Forms.Button btDelOperator;

        private System.Windows.Forms.Button btUseVpn;

        private System.Windows.Forms.Button btAddMoney;

        private System.Windows.Forms.Button btStartCall;

        private System.Windows.Forms.Button btChangeTariff;

        #endregion
    }
}