using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Work_Calculator
{
    public partial class StudentGrades : Form
    {
        public StudentGrades()
        {
            InitializeComponent(); 
        }
        
        internal struct Student
        {
            public string Name;
            public double Chinese;
            public double English;
            public double Math;            
        }
        Random Random = new Random();
        private double RndScore()
        {
            return Random.Next(101);
        }
        #region GetTextbox
        private double GetChinese()
        {
            double i;
            if (!double.TryParse(txtChinese.Text, out i) | i < 0 | i > 100)
            {
                MessageBox.Show("請輸入範圍內的數字");
                return double.NaN;
            }
            return i;
        }
        private double GetEnglish()
        {
            double j;
            if (!double.TryParse(txtEnglish.Text, out j) | j < 0 | j > 100)
            {
                MessageBox.Show("請輸入範圍內的數字");
                return double.NaN;
            }
            return j;
        }
        private double GetMath()
        {
            double k;
            if (!double.TryParse(txtMath.Text, out k) | k < 0 | k > 100)
            {
                MessageBox.Show("請輸入範圍內的數字");
                return double.NaN;
            }
            return k;
        }
        #endregion
        Student student = new Student();
        private void GetStatistic(double[] Statistic)
        {
            student.Chinese = GetChinese();
            student.English = GetEnglish();
            student.Math = GetMath();            

            Statistic[0] = student.Chinese;
            Statistic[1] = student.English;
            Statistic[2] = student.Math;
            Statistic[3] = student.Chinese + student.English + student.Math;
            Statistic[4] = (student.Chinese + student.English + student.Math) / 3;
            double[] S = { student.Chinese, student.English, student.Math };
            Statistic[5] = S.Max();
            Statistic[6] = S.Min();
        }
        private void GetRndStatistic(double[] RndStatistic)
        {
            student.Chinese = RndScore();
            student.English = RndScore();
            student.Math = RndScore();

            RndStatistic[0] = student.Chinese;
            RndStatistic[1] = student.English;
            RndStatistic[2] = student.Math;
            RndStatistic[3] = student.Chinese + student.English + student.Math;
            RndStatistic[4] = (student.Chinese + student.English + student.Math) / 3;
            double[] R = { student.Chinese, student.English, student.Math };
            RndStatistic[5] = R.Max();
            RndStatistic[6] = R.Min();
        }  

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double[] statistic = new double[7];
            GetStatistic(statistic);           
            if (string.IsNullOrEmpty(txtName.Text)) return;
            if (double.IsNaN(statistic[0])) return;
            if (double.IsNaN(statistic[1])) return;
            if (double.IsNaN(statistic[2])) return;

            student.Name = txtName.Text;
            ListViewItem score = new ListViewItem(student.Name);
            score.SubItems.Add(statistic[0].ToString());
            score.SubItems.Add(statistic[1].ToString());
            score.SubItems.Add(statistic[2].ToString());
            score.SubItems.Add(statistic[3].ToString());
            score.SubItems.Add(statistic[4].ToString("###.#"));
            score.SubItems.Add(statistic[5].ToString());
            score.SubItems.Add(statistic[6].ToString());
            listScore.Items.Add(score);
            txtName.Clear();
            txtChinese.Clear();
            txtEnglish.Clear();
            txtMath.Clear();
            txtName.Focus();
            if (listScore.Items.Count > 0)
            {
                btnStatistic.Enabled = true;
            }
        }

        int N = 1;        
        private void btnRandomAdd_Click(object sender, EventArgs e)
        {            
            double[] rndstatistic = new double[7];
            GetRndStatistic(rndstatistic);

            string Rndname = Convert.ToString(N++);
            ListViewItem score = new ListViewItem(Rndname);
            score.SubItems.Add(rndstatistic[0].ToString());
            score.SubItems.Add(rndstatistic[1].ToString());
            score.SubItems.Add(rndstatistic[2].ToString());
            score.SubItems.Add(rndstatistic[3].ToString());
            score.SubItems.Add(rndstatistic[4].ToString("###.#"));
            score.SubItems.Add(rndstatistic[5].ToString());
            score.SubItems.Add(rndstatistic[6].ToString());
            listScore.Items.Add(score);
            if (listScore.Items.Count > 0)
            {
                btnStatistic.Enabled = true;
            }
        }

        private void btnRandom20_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < 20; i++)
            {                
                double[] rndstatistic = new double[7];
                GetRndStatistic(rndstatistic);

                string Rndname = Convert.ToString(N++);
                ListViewItem score = new ListViewItem(Rndname);
                score.SubItems.Add(rndstatistic[0].ToString());
                score.SubItems.Add(rndstatistic[1].ToString());
                score.SubItems.Add(rndstatistic[2].ToString());
                score.SubItems.Add(rndstatistic[3].ToString());
                score.SubItems.Add(rndstatistic[4].ToString("###.#"));
                score.SubItems.Add(rndstatistic[5].ToString());
                score.SubItems.Add(rndstatistic[6].ToString());
                listScore.Items.Add(score);
            }
            if (listScore.Items.Count > 0)
            {
                btnStatistic.Enabled = true;
            }
        }
        
        private void ChineseStatistic(double[] chinese)
        {
            // 創建一個 double 類型的 List，用於存儲 Listview 中同一 column 的數字
            List<double> values = new List<double>();
            // 遍歷 Listview 中的所有項目
            foreach (ListViewItem item in listScore.Items)            
            {                
                double value = double.Parse(item.SubItems[1].Text);                
                values.Add(value);                
            }            
            chinese[0]= values.Sum();
            chinese[1] = values.Average();
            chinese[2] = values.Max();
            chinese[3] = values.Min();
        }
        private void EnglishStatistic(double[] English)
        {           
            List<double> values = new List<double>();           
            foreach (ListViewItem item in listScore.Items)
            {
                double value = double.Parse(item.SubItems[2].Text);
                values.Add(value);
            }            
            English[0] = values.Sum();
            English[1] = values.Average();
            English[2] = values.Max();
            English[3] = values.Min();
        }
        private void MathStatistic(double[] Math)        
        {           
            List<double> values = new List<double>();           
            foreach (ListViewItem item in listScore.Items)
            {
                double value = double.Parse(item.SubItems[3].Text);
                values.Add(value);
            }             
            Math[0] = values.Sum();
            Math[1] = values.Average();
            Math[2] = values.Max();
            Math[3] = values.Min();
        }
        
        private void btnStatistic_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            btnRandomAdd.Enabled = false;
            btnRandom20.Enabled = false;
            btnReset.Enabled = false;            
            double[] Chinese = new double[4];
            double[] English = new double[4];
            double[] Math = new double[4];
            ChineseStatistic(Chinese);
            EnglishStatistic(English);
            MathStatistic(Math);            
            
            labStatistic.Text = $"總分           {Chinese[0]}        {English[0]}        {Math[0]}\n"+
                                            $"平均           {Chinese[1]}        {English[1]}        {Math[1]}\n"+
                                            $"最高分        {Chinese[2]}        {English[2]}        {Math[2]} \n"+
                                            $"最低分        {Chinese[3]}        {English[3]}        {Math[3]}";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            listScore.Items.Clear();
            labStatistic.Text = string.Empty;
            if (!(listScore.Items.Count > 0))
            {
                btnStatistic.Enabled = false;
            }
        }
    }
}
