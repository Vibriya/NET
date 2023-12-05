using System.ComponentModel;

namespace LB_2
{
    partial class ChangeTariffView
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
            this.gbTariff = new System.Windows.Forms.GroupBox();
            this.rbTurbo = new System.Windows.Forms.RadioButton();
            this.rbPro = new System.Windows.Forms.RadioButton();
            this.rbMax = new System.Windows.Forms.RadioButton();
            this.rbStarter = new System.Windows.Forms.RadioButton();
            this.gbTariff.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbTariff
            // 
            this.gbTariff.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.gbTariff.Controls.Add(this.rbTurbo);
            this.gbTariff.Controls.Add(this.rbPro);
            this.gbTariff.Controls.Add(this.rbMax);
            this.gbTariff.Controls.Add(this.rbStarter);
            this.gbTariff.Location = new System.Drawing.Point(25, 24);
            this.gbTariff.Name = "gbTariff";
            this.gbTariff.Size = new System.Drawing.Size(241, 194);
            this.gbTariff.TabIndex = 0;
            this.gbTariff.TabStop = false;
            this.gbTariff.Text = "Tariff";
            // 
            // rbTurbo
            // 
            this.rbTurbo.Location = new System.Drawing.Point(21, 148);
            this.rbTurbo.Name = "rbTurbo";
            this.rbTurbo.Size = new System.Drawing.Size(91, 29);
            this.rbTurbo.TabIndex = 3;
            this.rbTurbo.TabStop = true;
            this.rbTurbo.Text = "Turbo";
            this.rbTurbo.UseVisualStyleBackColor = true;
            // 
            // rbPro
            // 
            this.rbPro.Location = new System.Drawing.Point(21, 108);
            this.rbPro.Name = "rbPro";
            this.rbPro.Size = new System.Drawing.Size(91, 34);
            this.rbPro.TabIndex = 2;
            this.rbPro.TabStop = true;
            this.rbPro.Text = "Pro";
            this.rbPro.UseVisualStyleBackColor = true;
            // 
            // rbMax
            // 
            this.rbMax.Location = new System.Drawing.Point(21, 70);
            this.rbMax.Name = "rbMax";
            this.rbMax.Size = new System.Drawing.Size(91, 32);
            this.rbMax.TabIndex = 1;
            this.rbMax.TabStop = true;
            this.rbMax.Text = "Max";
            this.rbMax.UseVisualStyleBackColor = true;
            // 
            // rbStarter
            // 
            this.rbStarter.Location = new System.Drawing.Point(21, 35);
            this.rbStarter.Name = "rbStarter";
            this.rbStarter.Size = new System.Drawing.Size(91, 29);
            this.rbStarter.TabIndex = 0;
            this.rbStarter.TabStop = true;
            this.rbStarter.Text = "Starter";
            this.rbStarter.UseVisualStyleBackColor = true;
            // 
            // ChangeTariffView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 238);
            this.Controls.Add(this.gbTariff);
            this.Name = "ChangeTariffView";
            this.Text = "ChangeTariffView";
            this.Shown += new System.EventHandler(this.ChangeTariffView_Shown);
            this.gbTariff.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.GroupBox gbTariff;
        private System.Windows.Forms.RadioButton rbStarter;
        private System.Windows.Forms.RadioButton rbMax;
        private System.Windows.Forms.RadioButton rbPro;
        private System.Windows.Forms.RadioButton rbTurbo;

        #endregion
    }
}