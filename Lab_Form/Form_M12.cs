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
    public partial class Form_M12 : Form
    {
        public Form_M12()
        {
            InitializeComponent();
            labCount.Text = "Count:2";
        }
        int num = 2;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            num *= 2;
            labCount.Text = "Count:" + num;
        }

        private void btnNum_Click(object sender, EventArgs e)
        {
            int result = ++num;
            //num += 1;
            //result = num ;

            labCount.Text = "Count:" + num;
            MessageBox.Show(result.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int result = num++;
            //result = num;
            //num += 1;

            labCount.Text = "Count:" + num;
            MessageBox.Show(result.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = 3;//方法變數
            
            if(true)
            {
                int b = 6; //區域變數
                
            }
            MessageBox.Show(a.ToString());
        }
        int c = 9;//類別變數
        private void button3_Click(object sender, EventArgs e)
        {
           
            MessageBox.Show(c.ToString());  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LabStatic.StaticNumber++;
            labStatic.Text = "Static Count: " + LabStatic.StaticNumber;
        }
        LabStatic ls = new LabStatic();
        private void button4_Click(object sender, EventArgs e)
        {
            
            ls.InstanceNumber++;
            labInstance.Text = "Instance Count: " + ls.InstanceNumber;
        }
    }
}
