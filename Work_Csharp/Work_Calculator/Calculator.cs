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
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }
        private double GetNum1()
        {
            double num1;
            if (!double.TryParse(txtNum1.Text, out num1))
            {
                MessageBox.Show("請輸入有效的數字！");
                return double.NaN;
            }
            return num1;
        }

        private double GetNum2()
        {
            double num2;
            if (!double.TryParse(txtNum2.Text, out num2))
            {
                MessageBox.Show("請輸入有效的數字！");
                return double.NaN;
            }
            return num2;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            double num1 = GetNum1();
            if (double.IsNaN(num1)) return;

            double num2 = GetNum2();
            if (double.IsNaN(num2)) return;

            double ans = num1 + num2;
            txtAns.Text = Convert.ToString(ans);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double num1 = GetNum1();
            if (double.IsNaN(num1)) return;

            double num2 = GetNum2();
            if (double.IsNaN(num2)) return;

            double ans = num1 - num2;
            txtAns.Text = Convert.ToString(ans);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            double num1 = GetNum1();
            if (double.IsNaN(num1)) return;

            double num2 = GetNum2();
            if (double.IsNaN(num2)) return;

            double ans = num1 * num2;
            txtAns.Text = Convert.ToString(ans);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double num1 = GetNum1();
            if (double.IsNaN(num1)) return;

            double num2 = GetNum2();
            if (double.IsNaN(num2)) return;

            if (num2 == 0)
            {
                MessageBox.Show("除數不能為零！");
                return;
            }

            double ans = num1 / num2;
            txtAns.Text = Convert.ToString(ans);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtNum1.Text = null;
            txtNum2.Text = null;
            txtAns.Text = null;
        }
    }
}
