using System;
using System.Windows.Forms;
using LB_2.Model.OperatorCompany;

namespace LB_2
{
    public partial class CreateCompanyView : Form
    {
        public Company Company;
        public CreateCompanyView()
        {
            InitializeComponent();
        }

        private void btCreateCompany_Click(object sender, EventArgs e)
        {
            try
            {
                Company = Company.Create(tbCompanyName.Text.Trim(), tbEDRPOY.Text.Trim());
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}