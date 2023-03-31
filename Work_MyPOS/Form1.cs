using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_MyPOS
{
    public partial class FormMyPOS : Form
    {
        int Beer = 0;
        int Teq = 0;
        int Whisky = 0;
        int Wine= 0;
        

        public FormMyPOS()
        {
            InitializeComponent();
            
            txtList.Text = "尚未點餐";
            
            
        }

        private void btnBeer_Click(object sender, EventArgs e)
        {
            Beer++;
            txtList.Text += $"啤酒X{Beer} , 共{Beer * 120}元";
        }

        private void btnTeq_Click(object sender, EventArgs e)
        {
            Teq++;
            txtList.Text += $"龍舌蘭X{Teq} , 共{Teq * 180}元";
        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            Whisky++;
            txtList.Text += $"威士忌X{Whisky} , 共{Whisky * 350}元";
        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            Wine++;
            txtList.Text += $"紅酒X{Wine} , 共{Wine * 320}元";
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            txtList.Text = "尚未點餐";
        }
        
        delegate decimal Payment(decimal total);
        decimal Money(decimal total)
        {
            return total*1;
        }
        decimal Card(decimal total)
        {
            return total * 9/10;
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            Payment pay=Money;
            decimal Price = decimal.Parse(txtList.Text);
            MessageBox.Show(Price.ToString(),"總共金額",MessageBoxButtons.OK);
        }

        private void btnCard_Click(object sender, EventArgs e)
        {
            Payment pay = Card;
            decimal Price = decimal.Parse(txtList.Text);
            MessageBox.Show(Price.ToString(), "總共金額", MessageBoxButtons.OK);
        }
    }
}
