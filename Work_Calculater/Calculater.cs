using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Calculater
{
    public partial class Calculater : Form
    {
        public Calculater()
        {
            InitializeComponent();              
         
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Calmethod Num=new Calmethod();
            Num.Num1 = Convert.ToInt32(txtNum1);
            Num.Num2 = Convert.ToInt32(txtNum2);
            Num.Answer = Num.Num1 + Num.Num2;
            txtAnswer.Text=Convert.ToString(Num.Answer);
        }
    }
}
