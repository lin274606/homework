using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Form_M15_CTS : Form
    {
        public Form_M15_CTS()
        {
            InitializeComponent();
        }

        private void btnValueType_Click(object sender, EventArgs e)
        {
            int a = 100;
            int b = a;

            MessageBox.Show($"a={a},b={b}");

            b = 200;

            MessageBox.Show($"a={a},b={b}");
        }

        private void btnReferenceType_Click(object sender, EventArgs e)
        {
            TextBox tb = txtReferenceType;
            tb.Text = "ReferenceType";
            tb.BackColor= Color.AliceBlue;
            tb.ForeColor= Color.Coral;
        }
    }
}
