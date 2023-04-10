using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Lab_Form
{
    public partial class Form_M32_String : Form
    {
        public Form_M32_String()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            string A = "AAA";
            string B = A;            
            MessageBox.Show($"A:{A}, B:{B}");

            B = "BBBB";            
            MessageBox.Show($"A:{A}, B:{B}");

            Mystring(B);
            MessageBox.Show($"A:{A}, B:{B}");


        }
        void Mystring(String X) 
        {
            X = "XXX";
        }

        private void btnStringBulider_Click(object sender, EventArgs e)
        {
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("This is StringBulider");
            MessageBox.Show(sb1.ToString());

            StringBuilder sb2 = sb1;
            MessageBox.Show($"sb1:{sb1} , sb2:{sb2}");

            sb2.Append(", Hello!");
            MessageBox.Show($"sb1:{sb1} , sb2:{sb2}");        

            
        }

        private void btnPath_Click(object sender, EventArgs e)
        {
            //string dir = "C:\\Users\\User\\Desktop\\FELV-cat.jpg";
            string dir = @"C:\Users\User\Desktop\FELV-cat.jpg";

            string result = "";

            result = Path.GetFullPath(dir) + "\n" + 
                        Path.GetExtension(dir) + "\n" +
                        Path.GetDirectoryName(dir) + "\n" + 
                        Path.GetPathRoot(dir) + "\n" + 
                        Path.GetFileName(dir);
            MessageBox.Show(result);

        }
        private void btnIsValid_Click(object sender, EventArgs e)
        {

        }
        //bool IsIDCorrect(string ID)
    }
}
