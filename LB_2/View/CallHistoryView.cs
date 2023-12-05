using System.Drawing;
using System.Windows.Forms;
using LB_1;

namespace LB_2
{
    public partial class CallHistoryView : Form
    {
        public CallHistoryView(MobileOperatorAccount selectedOperator)
        {
            InitializeComponent();
            
            if (selectedOperator.GetCalls().Length == 0) return;
            lbCallHistory.DataSource = selectedOperator.GetCalls();
            
            lbCallHistory.HorizontalScrollbar = true;
            var g = lbCallHistory.CreateGraphics();
            lbCallHistory.HorizontalExtent = (int) g.MeasureString(
                lbCallHistory.Items[lbCallHistory.Items.Count -1].ToString(),
                lbCallHistory.Font).Width;
        }
    }
}