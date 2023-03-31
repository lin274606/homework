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
    public partial class Form_M04 : Form
    {
        public Form_M04()
        {
            InitializeComponent();
        }

        private void OpenHelloForm_Click(object sender, EventArgs e)
        {
            Form_M02_HelloForm frm = new Form_M02_HelloForm();
            frm.Show();
        }

        private void btnMethod_Click(object sender, EventArgs e)
        {
            myFirstMethod();
        }
        void myFirstMethod()
        {
            string Name = "Vincent";
            MessageBox.Show($"My name is {Name} , this is my dog.");
        }

        private void btnReturnMethod_Click(object sender, EventArgs e)
        {
            int inputage=Convert.ToInt32(txtAge.Text);
            string result = Birthyear(inputage);
            MessageBox.Show(result);
        }
        string Birthyear(int age)
        {
            int birthYear=DateTime.Now.Year-age;
            return $"出生年是 {birthYear}";
        }

        private void btnMyclass_Click(object sender, EventArgs e)
        {
            Myclass mc = new Myclass();
            mc.Method03();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Myclass mc = new Myclass();
            mc.Method05();
        }

        private void btnPartialClass_Click(object sender, EventArgs e)
        {
            Myclass mc = new Myclass();
            mc.Method03();
            mc.Method06();

        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            Member mem1= new Member();
            mem1.Name = "John";
            mem1.Age = 30;

            string mem1name=mem1.Name;
            MessageBox.Show (mem1name+" , "+mem1.Age);

            Member mem2 = new Member
            {
                Name = "Wick",
                Age = 32
            };
            MessageBox.Show(mem2.Name + " , " + mem2.Age);



        }
    }
}
