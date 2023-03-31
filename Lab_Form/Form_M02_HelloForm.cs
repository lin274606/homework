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
    public partial class Form_M02_HelloForm : Form
    {
        public Form_M02_HelloForm()
        {
            InitializeComponent();
        }

        private void btnName_Click(object sender, EventArgs e)
        {
            string Name= txtName.Text;
            string ENname= txtENname.Text;
            string Gender = txtGender.Text;
            string Zodiac = txtZodiac.Text;

            MessageBox.Show($"Hello, 我是 {Name}\r" +
                                                $"I am {ENname}\r" +
                                                $"性別是 {Gender}\r" +
                                                $"星座是 {Zodiac}");
            

        }
    }
}
