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
    public partial class Form_M19_struct : Form
    {
        public Form_M19_struct()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int Age = 0;
            bool isNum=int.TryParse(txtEmpAge.Text, out Age);
            if (isNum)
            {
                Employee emp = new Employee(txtEmpName.Text, Age);
                labEmp.Text += $"\n姓名：{emp.Name}   年齡：{emp.Age}";              
                
            }
            else
            {
                MessageBox.Show("年齡格式錯誤");
                txtEmpAge.Clear();
                txtEmpAge.Focus();
            }
            
        }
    }
}
