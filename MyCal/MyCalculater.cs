using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyCal
{
    public partial class MyCalc : Form
    {
        public MyCalc()
        {
            InitializeComponent();           
        }
        

        private void btnAdd_Click(object sender, EventArgs e)
        {
             int num1 = int.Parse(txtNum1.Text);
             int num2 = int.Parse(txtNum2.Text);
             int ans=num1 + num2;
             txtAns.Text = Convert.ToString(ans);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);
            int ans = num1 - num2;
            txtAns.Text = Convert.ToString(ans);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(txtNum1.Text);
            double num2 = int.Parse(txtNum2.Text);
            double ans = num1 * num2;
            txtAns.Text = Convert.ToString(ans);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1 = int.Parse(txtNum1.Text);
            double num2 = int.Parse(txtNum2.Text);
            double ans = num1 / num2;
            txtAns.Text = Convert.ToString(ans);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum1.Text = null;
            txtNum2.Text=null;
            txtAns.Text=null;
        }
    }
}
