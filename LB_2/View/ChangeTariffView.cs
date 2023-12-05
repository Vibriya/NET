using System;
using System.Windows.Forms;
using LB_1;

namespace LB_2
{
    public partial class ChangeTariffView : Form
    {
        private readonly MobileOperatorAccount _selectedOperator;
        public ChangeTariffView(MobileOperatorAccount selectedOperator)
        {
            InitializeComponent();
            _selectedOperator = selectedOperator;
        }

        private void RadioCheckedChanged(object sender, EventArgs e)
        {
            var radioButton = (RadioButton)sender;
            DialogResult = DialogResult.Abort;
            if (radioButton.Checked)
            {
                Tariff tariff;
                switch (radioButton.Text)
                {
                    case "Max": tariff = new TariffMax(); break;
                    case "Pro": tariff = new TariffPro(); break;
                    case "Turbo": tariff = new TariffTurbo(); break;
                    default: tariff = new TariffStarter(); break;
                }
                _selectedOperator.ChangeTariff(tariff);
                DialogResult = DialogResult.OK;
            }
            Close();
        }

        private void ChangeTariffView_Shown(object sender, EventArgs e)
        {
            switch (_selectedOperator.Tariff.Name)
            {
                case "Max": rbMax.Checked = true; break;
                case "Pro": rbPro.Checked = true; break;
                case "Turbo": rbTurbo.Checked = true; break;
                default: rbStarter.Checked = true; break;
            }
            
            rbStarter.CheckedChanged +=  RadioCheckedChanged;
            rbMax.CheckedChanged += RadioCheckedChanged;
            rbPro.CheckedChanged += RadioCheckedChanged;
            rbTurbo.CheckedChanged += RadioCheckedChanged;
        }
    }
}