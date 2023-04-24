using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Calculator
{
    public partial class Work_Loan : Form
    {
        public Work_Loan()
        {
            InitializeComponent();
        }
        public string GetLoanAmount()
        {
            return txtLoanAmount.Text;
        }
        public string GetTerm()
        {
            return txtTerm.Text;
        }
        public string GetRates()
        {
            return txtRates.Text;
        }

        public decimal GetPayment()
        {
            double Month = double.Parse(txtTerm.Text) * 12.0;
            double MonthlyRate = double.Parse(txtRates.Text) / 1200.0;
            decimal LoanAmount = decimal.Parse(txtLoanAmount.Text);
            decimal DownPayment = decimal.Parse(txtDownPayment.Text);
            decimal PayableAmount =
               (LoanAmount - DownPayment) *
               (decimal)(Math.Pow(1 + MonthlyRate, Month) * MonthlyRate /
               (Math.Pow(1 + MonthlyRate, Month) - 1));
            return PayableAmount;
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            decimal PayableAmount = GetPayment();           
            MessageBox.Show($"{PayableAmount:C0} 元");
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {            
            decimal PayableAmount = GetPayment();
            decimal Month = decimal.Parse(txtTerm.Text)*12;
            MessageBox.Show($"{PayableAmount * Month:C0} 元");
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Work_LoanReport report = new Work_LoanReport();
            report.Show();
        }
    }
}
