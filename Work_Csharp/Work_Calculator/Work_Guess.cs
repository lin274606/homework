using System;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Calculator
{
    public partial class Work_Guess : Form
    {
        public Work_Guess()
        {
            InitializeComponent();
            GetAnswer();// 初始化時產生答案
        }

        Random random = new Random();
        int answer;        
        int firstNumber = 0;
        int secondNumber = 99;


        private void GetAnswer()
        {
            answer = random.Next(100);            
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            do
            {
                string Userinput = Interaction.InputBox("請輸入數字");
                if (string.IsNullOrEmpty(Userinput))
                {
                    break;
                }
                else if (int.Parse(Userinput) < 0 | int.Parse(Userinput) > 99)
                {
                    MessageBox.Show("請輸入範圍內的數字！", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }      
                else
                {
                    int UserNumber = int.Parse(Userinput);
                    if (UserNumber < answer)
                    {
                        firstNumber = UserNumber;
                        labNumber.Text = string.Format($"太小 , 數字在 {firstNumber} 到 {secondNumber} 間");
                    }
                    else if(UserNumber > answer)
                    {
                        secondNumber = UserNumber;
                        labNumber.Text = string.Format($"太大 , 數字在 {firstNumber} 到 {secondNumber} 間");
                    }
                    else
                    {
                        MessageBox.Show(string.Format($"答對,數字是 {answer}"));
                        break;
                    }
                }

            }while (true);
          
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format($"答案是 {answer}"));
            GetAnswer();//產生新數字
        }
    }
}
