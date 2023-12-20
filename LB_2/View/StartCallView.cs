using System;
using System.Windows.Forms;
using LB_1;

namespace LB_2
{
    public partial class StartCallView : Form
    {
        private readonly MobileOperatorAccount _selectedOperator;
        public StartCallView(MobileOperatorAccount selectedOperator)
        {
            InitializeComponent();
            _selectedOperator = selectedOperator;
        }

        private void btCall_Click(object sender, EventArgs e)
        {
            try
            {
                var result = _selectedOperator.StartCall(
                    uint.Parse(tbMinutes.Text.Trim()),
                    tbToNumber.Text.Trim(),
                    out var price
                ).ToString();
                
                MessageBox.Show($"Price: {price}", result);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}