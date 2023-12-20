using System;
using System.Windows.Forms;
using LB_1;

namespace LB_2
{
    public partial class NewOperatorView : Form
    {
        public MobileOperatorAccount Operator;
        public NewOperatorView()
        {
            InitializeComponent();
            cbTariff.SelectedIndex = 0;
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            Tariff tariff;
            switch (cbTariff.Items[cbTariff.SelectedIndex].ToString())
            {
                case "Max": tariff = new TariffMax(); break;
                case "Pro": tariff = new TariffPro(); break;
                case "Turbo": tariff = new TariffTurbo(); break;
                default: tariff = new TariffStarter(); break;
            }

            try
            {
                Operator = MobileOperatorAccount.Create(
                    tbName.Text,
                    tariff,
                    cbPaid.Checked,
                    cbRoaming.Checked,
                    int.Parse(tbAccount.Text), 
                    tbNumber.Text
                );
                
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}