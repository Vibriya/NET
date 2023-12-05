using System;
using System.Windows.Forms;
using LB_1;
using LB_2.Model.OperatorCompany;

namespace LB_2
{
    public partial class NewOperatorView : Form
    {
        public MobileOperatorAccount Operator;
        private Company _company;
        public NewOperatorView(Company company)
        {
            InitializeComponent();
            cbTariff.SelectedIndex = 0;
            _company = company;
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
                    _company,
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