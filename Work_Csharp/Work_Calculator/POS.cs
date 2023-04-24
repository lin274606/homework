using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Work_Calculator
{
    public partial class POS : Form
    {
        public POS()
        {
            InitializeComponent();
            foreach (string product in products.Keys)
            {
                listProducts.Items.Add($"{product}");
            }
        }

        private Dictionary<string, decimal> products = new Dictionary<string, decimal>()
        {
            {"啤酒", 120},
            {"龍舌蘭", 180},
            {"威士忌", 350},
            {"紅酒", 320}
        };
        private Dictionary<string, int> quantities = new Dictionary<string, int>()
        {
            {"啤酒", 0},
            {"龍舌蘭", 0},
            {"威士忌", 0},
            {"紅酒", 0}
        };
        
        private decimal total = 0;
        private List<string> cart = new List<string>();        
        
        private void btnBeer_Click(object sender, EventArgs e)
        {
            string product = "啤酒";
            decimal price = products[product];
            quantities[product]++;
            
            total += price;
            cart.Add(product);
           
            printall();

            // 更新總金額
            txtTotal.Text = $"{total:C}";

            
                
        }

        private void btnTeq_Click(object sender, EventArgs e)
        {
            string product = "龍舌蘭";
            decimal price = products[product];
            quantities[product]++;
            total += price;
            cart.Add(product);

            printall();

            // 更新總金額
            txtTotal.Text = $"{total:C}";

            

        }

        private void btnWhisky_Click(object sender, EventArgs e)
        {
            string product = "威士忌";
            decimal price = products[product];
            quantities[product]++;
            total += price;
            cart.Add(product);

            printall();

            // 更新總金額
            txtTotal.Text = $"{total:C}";
           

        }

        private void btnWine_Click(object sender, EventArgs e)
        {
            string product = "紅酒";
            decimal price = products[product];
            quantities[product]++;
            total += price;
            cart.Add(product);

            printall();

            // 更新總金額
            txtTotal.Text = $"{total:C}";

            
        }
        public void printall()
        {
            listProducts.Items.Clear();
            foreach (string product in products.Keys)
            {
                if (quantities[product] >= 1)
                {
                    ListViewItem item = new ListViewItem(product);
                    item.SubItems.Add((quantities[product]* products[product]).ToString());
                    item.SubItems.Add(quantities[product].ToString());
                    listProducts.Items.Add(item);
                }
                else
                {
                    listProducts.Items.Add($"{product}");
                }
               
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            listProducts.Items.Clear();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"共{total:C}元");
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"共{total*0.9m:C}元");
        }
    }
}
