using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Loop
{
    public partial class Loop : Form
    {
        public Loop()
        {
            InitializeComponent();
        }
        #region -- GetTextbox --
        private double GetFrom()
        {
            double i;
            if (!double.TryParse(txtFrom.Text, out i) | i <= 0)
            {
                MessageBox.Show("請輸入正整數");
                return double.NaN;
            }
            return i;
        }

        private double GetTo()
        {
            double j;
            if (!double.TryParse(txtTo.Text, out j) | j <= 0)
            {
                MessageBox.Show("請輸入正整數");
                return double.NaN;
            }
            return j;
        }
        private double GetStep()
        {
            double k;
            if (!double.TryParse(txtStep.Text, out k) | k<=0)
            {
                MessageBox.Show("請輸入正整數");
                return double.NaN;
            }
            return k;            
        }
        private double GetRows()
        {
            double R;
            if (!double.TryParse(txtRows.Text, out R) | R <= 0)
            {
                MessageBox.Show("請輸入正整數");
                return double.NaN;
            }
            return R;
        }
        #endregion
        private void btnFor_Click(object sender, EventArgs e)
        {
            double From = GetFrom(), To = GetTo(), Step = GetStep(), Total = 0;
            if (double.IsNaN(From)) return;
            if (double.IsNaN(To)) return;
            if (double.IsNaN(Step)) return;

            for (double num = From; num <= To; num += Step)
            {
                Total += num;
            }
            labResult.Text = ($"從{From}到{To}相隔{Step - 1}總合為{Total}");
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            double From = GetFrom(), To = GetTo(), Step = GetStep(), Total = 0;
            double num = From;
            if (double.IsNaN(From)) return;
            if (double.IsNaN(To)) return;
            if (double.IsNaN(Step)) return;

            while (num <= To)
            {
                Total += num;
                num += Step;
            }
            labResult.Text = ($"從{From}到{To}相隔{Step - 1}總合為{Total}");
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            double From = GetFrom(), To = GetTo(), Step = GetStep(), Total = 0;
            double num = From;
            if (double.IsNaN(From)) return;
            if (double.IsNaN(To)) return;
            if (double.IsNaN(Step)) return;

            do
            {
                Total += num;
                num += Step;
            }
            while (num <= To);
            labResult.Text = ($"從{From}到{To}相隔{Step - 1}總合為{Total}");
        }

        
        public static string RT="";
        private void btnRightTriangle_Click(object sender, EventArgs e)
        {
            double Rows = GetRows();
            if (double.IsNaN(Rows)) return;
            for (double i=1; i<=Rows; i++)
            {
                for (double j=1; j<=i ; j++)
                {
                    Loop.RT += "*";
                }
                Loop.RT += "\n";
            }
            labResult.Text = Loop.RT;
        }
        public static string IT = "";
        private void btnIsoTriangle_Click(object sender, EventArgs e)
        {
            double Rows = GetRows();
            if (double.IsNaN(Rows)) return;
            double space=Rows-1;
            for (double i = 1 ; i <= Rows ; i++)
            {
                for (double j = 1 ; j <=space  ; j++)
                {
                    Loop.IT += " ";
                }
                space--;
                for (double k = 1 ; k<=i ; k++)
                {
                    Loop.IT += "*";
                }
                Loop.IT += "\n";
            }
            labResult.Text = Loop.IT;
        }
        public static string Table = "";
        private void btnTable_Click(object sender, EventArgs e)
        {
            for (int i = 2; i <= 9; i++)
            {
                for(int j = 1; j <= 9 ; j++)
                {
                    Loop.Table += $"{i}*{j}={i*j:00}| ";
                }
                Loop.Table += "\n";
            }
            labResult.Text = Loop.Table;
        }

        private int GetNumber()
        {
            int number;
            if (!int.TryParse(txtNumber.Text, out number) | number <= 0)
            {
                MessageBox.Show("請輸入正整數");
                return -1;
            }
            return number;
        }
        private void btnOddOrEven_Click(object sender, EventArgs e)
        {
            int number = GetNumber();
            if (number<0) return;
            if (number % 2 == 0)
            {
                labResult.Text = $"{number} 是偶數";
            }
            else if (number % 2 == 1)
            {
                labResult.Text = $"{number} 是奇數";
            }
        }
        int[] arr0415 = { 1, 2, 3, 5, 8, 13, 21, 34 };         

        private void button1_Click(object sender, EventArgs e)
        {            
            labResult.Text = $"int陣列arr0415 [ {string.Join(",", arr0415)} ]\n"+
                                            $"最大值為{arr0415.Max()}\n" +
                                            $"最小值為{arr0415.Min()}\n"+
                                            $"總和為{arr0415.Sum()}";

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int odd=0, even=0;
            foreach (int i in arr0415)
            {
                switch (i%2)
                {
                    case 0:
                        odd++;
                        break;
                    case 1:
                        even++;
                        break;
                }
            }            
            labResult.Text = $"int陣列arr0415 [ {string.Join(",", arr0415)} ]\n" +
                                          $"奇數有{odd}個\n" +
                                          $"偶數有{even}個";
        }

        string[] namelist = { "Ashley", "Beatrice", "Carol", "Xylia", "Yvonne", "Zoe" };
       
        
        private void button3_Click(object sender, EventArgs e)
        {
            string longestString = namelist.Max(s => s.Length == namelist.Max(x => x.Length) ? s : null);
            labResult.Text =$"string陣列namelist\n[ {string.Join(",", namelist)} ]\n"+
                                         $"最長的名字是 {longestString}";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            char targetCharU = 'A';
            char targetCharL = 'a';
            int countU = namelist.Count(x => x.Contains(targetCharU));
            int countL = namelist.Count(x => x.Contains(targetCharL));
            int count = countU + countL;
            labResult.Text = $"string陣列namelist\n[ {string.Join(",", namelist)} ]\n" +
                                          $"有'A'或'a'的名字有{count}個";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int[,] myArray = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        myArray[i, j] = 1;
                    }
                    else
                    {
                        myArray[i, j] = 0;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append(myArray[i, j]+" ");
                }
                sb.Append("\n");
            }
            labResult.Text = sb.ToString();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int[,] myArray = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == 0 || i == 9 || j == 0 || j == 9)
                    {
                        myArray[i, j] = 0;
                    }
                    else
                    {
                        myArray[i, j] = 1;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append(myArray[i, j] + " ");
                }
                sb.Append("\n");
            }
            labResult.Text = sb.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int[,] myArray = new int[10, 10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if ((i + j) % 2 == 0)
                    {
                        myArray[i, j] = 1;
                    }
                    else
                    {
                        myArray[i, j] = 0;
                    }
                }
            }
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    sb.Append(myArray[i, j] + " ");
                }
                sb.Append("\n");
            }
            labResult.Text = sb.ToString();
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            int A = 111 , B = 666;
            labResult.Text = $"交換前A = {A} , B = {B}\n";
            int T = A; A = B; B = T;
            labResult.Text += $"交換後A = {A} , B = {B}";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string binaryString = Convert.ToString(100, 2);
            labResult.Text = binaryString;
        }

        private void button9_Click(object sender, EventArgs e)
        {            
            Random random = new Random();            
            List<int> numbers = Enumerable.Range(1, 48).ToList();  // 創建一個包含1到48的整數列表           
            List<int> selectedNumbers = new List<int>();   // 從列表中隨機選擇六個元素
            for (int i = 0; i < 6; i++)
            {                
                int index = random.Next(numbers.Count);  // 隨機選擇一個索引                
                int selectedNumber = numbers[index];  // 從列表中取出對應索引的元素                
                selectedNumbers.Add(selectedNumber);  // 將選中的元素添加到新列表中                
                numbers.RemoveAt(index);  // 從原列表中移除已選中的元素
            }
            labResult.Text = $"1~48隨機6個數不重複\n";
            foreach (int number in selectedNumbers)
            {
                labResult.Text += $"{number} ";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labResult.Text = "結果";
        }
    }
}
