using System;
using System.Windows.Forms;
using LB_1;

namespace LB_2
{
    public partial class UseVpnView : Form
    {
        private readonly MobileOperatorAccount _selectedOperator;
        public UseVpnView(MobileOperatorAccount selectedOperator)
        {
            InitializeComponent();
            _selectedOperator = selectedOperator;
        }

        private void btUseVpn_Click(object sender, EventArgs e)
        {
            if (uint.TryParse(tbMegabytes.Text.Trim(), out uint res))
            {
                MessageBox.Show(
                    _selectedOperator.UseVpn(res).ToString(),
                    "Wasted money"
                );
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