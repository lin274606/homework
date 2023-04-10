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
    public partial class Form_M21 : Form
    {
        public Form_M21()
        {
            InitializeComponent();
        }
        bool flag = true;
        private void btn_Click(object sender, EventArgs e)
        {
            //if (flag)
            //{
            //    btn.BackColor = Color.Crimson;
            //}
            //else
            //{
            //    btn.BackColor = Color.RoyalBlue;
            //}
            btn.BackColor=flag? Color.Red : Color.Green;
            flag=!flag;
        }

        private void btnGrade_Click(object sender, EventArgs e)
        {
            int Score;
            if(int.TryParse(txtScore.Text,out Score))
            {
                if (Score > 90 && Score <= 100)
                    labGrade.Text = "級數：A";
                else if (Score >= 80)
                    labGrade.Text = "級數：B";
                else if (Score >= 70)
                    labGrade.Text = "級數：C";
                else if (Score >= 60)
                    labGrade.Text = "級數：D";
                else
                    labGrade.Text = "級數：E";

            }            
                MessageBox.Show("請輸入正確分數");
                txtScore.Clear();
                txtScore.Focus();           
                      
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("有沒有帶傘", "注意天氣", MessageBoxButtons.YesNoCancel);
            
            switch (result)
            {
                case DialogResult.Yes :
                    MessageBox.Show("可能下雨");
                    break;
                case DialogResult.No :
                    MessageBox.Show("希望別下雨");
                    break;
                default :
                    MessageBox.Show("Default");
                    break;
                

            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int num = 10;
            string result = "";
            while (num <= 9) 
            {
                result += num + "\n";
                num++;
            }
            MessageBox.Show(result);
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            int num = 10;
            string result = "";
            do
            {
                if (num > 9)
                {
                    MessageBox.Show("> 9");
                    break;
                }
                result += num + "\n";
                num++;
            } while (num <= 9) ;
                MessageBox.Show(result);
        }

        private void btnFor_Click(object sender, EventArgs e)
        {            
            string result = "";
            for(int k = 2; k <= 9; k++)
            {
                for (int i = 1, j = 10; i <= 5; i++,j --)
                {
                    result += $"{k:D2}*{i:D2}={k*i:D2}|"+
                                      $"{k:D2}*{j:D2}={k*j:D2}|";
                }
                result += "\n";
            } 
            MessageBox.Show(result);
        }

        private void btnForeach_Click(object sender, EventArgs e)
        {
            foreach (Control item in this.Controls)
            {
                //if (item.GetType() != typeof(Button))
                //{
                //    continue;
                //}
                if (!(item is Button))
                {
                    continue;
                }
                item.ForeColor = Color.Violet;
                item.BackColor = Color.Crimson;
                item.Left += -10;
                item.Top += 10;

            }
        }
    }
}
