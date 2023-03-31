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
    public partial class Form_M18_enum : Form
    {
        public Form_M18_enum()
        {
            InitializeComponent();
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            //int Role = 0;
            //if(Role == Convert.ToInt32(UserRole.Admin))
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}
            
            UserRole Role = UserRole.User;
            
            //if (Role == UserRole.Admin)
            //{
            //    btnProduct.Enabled = true;
            //}
            //else
            //{
            //    btnProduct.Enabled = false;
            //}

            switch(Role)
            {
                case UserRole.Admin:
                    btnProduct.Enabled = true;
                    break;
                case UserRole.User:
                    btnProduct.Enabled = false; 
                    break;
            }
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Product");
        }
    }
}
