using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Struct
{
    
    public partial class StudentStruct : Form
    {
        public StudentStruct()
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
        private double GetChinese()
        {
            double i;
            if (!double.TryParse(txtChinese.Text, out i) | i < 0 | i >100)
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            double Chinese = GetChinese(), English = GetEnglish(), Math = GetMath();
            if (string.IsNullOrEmpty(txtName.Text)) return;
            if (double.IsNaN(Chinese)) return;
            if (double.IsNaN(English)) return;
            if (double.IsNaN(Math)) return;
            Student student = new Student
            {
                Name = txtName.Text,
                Chinese = GetChinese(),
                English = GetEnglish(),
                Math = GetMath()
            };
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            double Chinese = GetChinese(), English = GetEnglish(), Math = GetMath();
            if (string.IsNullOrEmpty(txtName.Text)) return;
            if (double.IsNaN(Chinese)) return;
            if (double.IsNaN(English)) return;
            if (double.IsNaN(Math)) return;
            Student student = new Student
            {
                Name = txtName.Text,
                Chinese = GetChinese(),
                English = GetEnglish(),
                Math = GetMath()
            };
            labList.Text = $"姓名：{student.Name}\n" +
                                   $"國文：{student.Chinese}\n" +
                                   $"英文：{student.English}\n" +
                                   $"數學：{student.Math}\n";           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtName.Text = string.Empty;
            txtChinese.Text = string.Empty;
            txtEnglish.Text = string.Empty;
            txtMath.Text = string.Empty;
            labList.Text = string.Empty;
            labMaxMin.Text = string.Empty;
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            double Chinese = GetChinese(), English = GetEnglish(), Math = GetMath();
            if (double.IsNaN(Chinese)) return;
            if (double.IsNaN(English)) return;
            if (double.IsNaN(Math)) return;
            Student student = new Student
            {
                Name = txtName.Text,
                Chinese = GetChinese(),
                English = GetEnglish(),
                Math = GetMath()
            };
            Dictionary<double, string> scoreDict = new Dictionary<double, string>
            {
                { student.Chinese, "國文" },
                { student.English, "英文" },
                { student.Math, "數學" }
            };

            double maxScore = scoreDict.Keys.Max();
            double minScore = scoreDict.Keys.Min();

            string maxSubject = scoreDict[maxScore];
            string minSubject = scoreDict[minScore];

            labMaxMin.Text = $"最高分是：{maxScore}，科目為：{maxSubject}\n" +
                                             $"最低分是：{minScore}，科目為：{minSubject}";
        }
    }
}
