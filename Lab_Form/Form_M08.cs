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
    public partial class Form_M08 : Form
    {
        public Form_M08()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            btnRegister01.Click += new EventHandler(this.btnRegister01_Click);
            btnRegister02.Click += new EventHandler(btnRegister02_Click);
        }

        private void btnRegister02_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register02");
        }

        private void btnRegister01_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Register01");
        }
    }
}
