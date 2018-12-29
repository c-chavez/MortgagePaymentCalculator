using System;
using System.Windows.Forms;

namespace MortgagePaymentCalculator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
          var apr =  GetCalculator().APR;
        }

        private void tabCtrlMain_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                var calculator = GetCalculator();
                dgvAmortization.DataSource = calculator.GetAmortizationTable();
            }
        }

        private PaymentCalc GetCalculator()
        {
            var calculator =
                PaymentCalc.CreateCalc(numUpDwnAmount.Value, (int)numUpDwnLoanTerm.Value, numUpDwnRate.Value, (int)numUpDwnPaymentsPerYear.Value, numUpDwnDownPayment.Value);

            return calculator;
        }
    }
}
