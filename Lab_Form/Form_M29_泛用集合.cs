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
    public partial class Form_M29_泛用集合 : Form
    {
        public Form_M29_泛用集合()
        {
            InitializeComponent();
        }
        List<Product> IsPro = new List<Product>();
        Product pro;
        void ShowProductList()
        {
            decimal totalPrice = 0;
            labShow.Text = "產品\n";            
            foreach (Product pro in IsPro)
            {
                labShow.Text += $"名稱:{pro.Name} , " +
                                                $"單價:{pro.Price}\n";
                totalPrice += pro.Price;
            }
            decimal avgPrice = IsPro.Count == 0 ? 0 : totalPrice / IsPro.Count;
            labShow.Text += $"------------\n" +
                                            $"產品個數:{IsPro.Count}\n" +
                                            $"產品總價:{totalPrice:C2}\n" +
                                            $"平均單價:{avgPrice:C2}";
        }        
        
        public decimal GetPriceNum()
        {
            if (!decimal.TryParse(txtProductPrice.Text, out pro.Price) | pro.Price < 0)
            {
                MessageBox.Show("請輸入正整數或零");
                return pro.Price = -1;
            }
            return pro.Price;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtProductName.Text)) return;
            GetPriceNum();
            if (pro.Price < 0) return;

            pro.Name = txtProductName.Text;
            IsPro.Add(pro);
            ShowProductList();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            GetPriceNum();
            if (pro.Price < 0) return;

            pro.Name = txtProductName.Text;
            IsPro.Insert(0, pro);
            ShowProductList();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            IsPro.Clear();
            ShowProductList();
        }

        private void btnRemoveAt_Click(object sender, EventArgs e)
        {
            IsPro.RemoveAt(0);
            ShowProductList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //測試不同資料型態
            //IsPro.Add("string");
            //IsPro.Add(100);
            ShowProductList();
        }
    }
}
