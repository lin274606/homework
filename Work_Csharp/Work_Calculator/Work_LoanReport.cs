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
    public partial class Work_LoanReport : Form
    {
        public Work_LoanReport()
        {
            InitializeComponent();
            Work_Loan loan = new Work_Loan();
            txtLoanAmount.Text = loan.GetLoanAmount();
            txtTerm.Text = loan.GetTerm();
            txtRates.Text = loan.GetRates();
            decimal PayableAmount = loan.GetPayment();
            txtMonthly.Text = $"{PayableAmount:C0} 元";
            decimal Month = decimal.Parse(txtTerm.Text) * 12;
            txtTotal.Text = $"{PayableAmount * Month:C0} 元";
        }       
        

    }
}
