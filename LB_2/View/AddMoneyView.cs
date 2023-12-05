using System;
using System.Windows.Forms;
using LB_1;

namespace LB_2
{
    public partial class AddMoneyView : Form
    {
        private readonly MobileOperatorAccount _selectedOperator;
        public AddMoneyView(MobileOperatorAccount selectedOperator)
        {
            InitializeComponent();
            _selectedOperator = selectedOperator;
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(tbMoney.Text, out var res))
            {
                _selectedOperator.AddMoney(res);
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Can't convert to uint");
            }
        }
    }
}