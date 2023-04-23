using System;
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
    public partial class Work_Hello : Form
    {
        public Work_Hello()
        {
            InitializeComponent();
        }

        private void btnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello , 我是{txtName.Text}\n" +
                                              $"英文名字是{txtENName.Text}\n" +
                                              $"星座是{txtZodiac.Text}\n" +
                                              $"性別是{txtGender.Text}\n" +
                                              $"很高興認識你") ;
        }

        private void btnHi_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi , 我是{txtName.Text}\n" +
                                             $"英文名字是{txtENName.Text}\n" +
                                             $"星座是{txtZodiac.Text}\n" +
                                             $"性別是{txtGender.Text}\n"+
                                             $"很高興認識你");
        }
    }
}
