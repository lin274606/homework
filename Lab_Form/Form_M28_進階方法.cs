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
    public partial class Form_M28_進階方法 : Form
    {
        public Form_M28_進階方法()
        {
            InitializeComponent();
        }
        void Swap(ref int A, ref int B)
        {
            int T = A;
            A = B;
            B = T;
        }
        void Swap(ref string A, ref string B)
        {
            string T = A;
            A = B;
            B = T;
        }
        void GenericSwap<Z>(ref Z A, ref Z B)
        {
            Z zz = A;
            A = B;
            B = zz;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int intA = 100, intB = 200;
            GenericSwap<int>(ref intA,ref intB);
            MessageBox.Show($"a:{intA} , b:{intB}");

            string strA = "aaaaaa", strB = "bbbb";
            GenericSwap<string>(ref strA,ref strB);
            MessageBox.Show($"a:{strA} , b:{strB}");

        }
        private void button1_Click(object sender, EventArgs e)
        {
            int a = 100,b=200;
            MessageBox.Show($"a:{a} , b:{b}");
            Swap(ref a,ref b);
            MessageBox.Show($"a:{a} , b:{b}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string a = "aaaaa", b = "bbb";
            MessageBox.Show($"a:{a} , b:{b}");
            Swap(ref a, ref b);
            MessageBox.Show($"a:{a} , b:{b}");
        }

        
    }
}
