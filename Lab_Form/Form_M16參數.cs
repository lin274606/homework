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
    public partial class Form_M16參數 : Form
    {
        public Form_M16參數()
        {
            InitializeComponent();
        }


        private void btnByReference_Click(object sender, EventArgs e)
        {
            Member m1 = new Member();
            m1.Name = "John";
            m1.Age = 40;
            MessageBox.Show($"Name:{m1.Name} , Age:{m1.Age}");
            byReference(m1);
            MessageBox.Show($"Name:{m1.Name} , Age:{m1.Age}");
        }

        void byReference(Member member)
        {
            member.Age = 22;
        }

        private void btnByValue_Click(object sender, EventArgs e)
        {
            int num = 100;
            MessageBox.Show("num="+num);
            byValue(num);
            MessageBox.Show("num="+num);
        }
        void byValue(int num)//傳值
        {
            num = 1000;
        }

        private void btnByref_Click(object sender, EventArgs e)
        {
            int num = 1;
            byref(ref num);
            MessageBox.Show("number=" + num);
        }
        void byref(ref int Number)//傳址
        {
            Number = 999;
        }

        private void btnByOut_Click(object sender, EventArgs e)
        {
            int num = 1;
            ByOut(out num);
            MessageBox.Show("num=" + num);
        }
        void ByOut(out int Number)
        {
            Number = 888;
        }

        private void btnParams_Click(object sender, EventArgs e)
        {
            string chi = Myparams("國文", 85, 95, 65, 78, 58);
            MessageBox.Show(chi);
            string math = Myparams("數學", 76, 66,56);
            MessageBox.Show(math);
        }
        string Myparams(string Subject, params int[] Scores)
        {
            double total = 0;
            double average=0;
            for (int i =0;i<Scores.Length;i++)
            {
                total += Scores[i];
                average = total/ Scores.Length;
            }           
            return $"{Subject}的總成績是{total}分\n"+
                        $"{Subject}的平均成績是{average}分";
        }
    }
}
