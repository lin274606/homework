using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Form
{
    public partial class Form_M34_ReadWrite : Form
    {
        public Form_M34_ReadWrite()
        {
            InitializeComponent();
        }

        private void btnReader_Click(object sender, EventArgs e)
        {
            //StreamReader sr = new StreamReader(
            //    "C:\\Users\\User\\source\\repos\\Lab_Csharp\\Lab_Form\\bin\\Release\\Read.txt",
            //    Encoding.UTF8);
            StreamReader sr = new StreamReader("../Read.txt", Encoding.UTF8);
            txtShow.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void bntStreamWriter_Click(object sender, EventArgs e)
        {
            FileStream fs= new FileStream(@"Writer.txt",FileMode.Create);
            StreamWriter sw= new StreamWriter(fs, Encoding.Default);
            sw.Write(txtShow.Text);
            sw.Close();
            fs.Close();
        }
    }
}
