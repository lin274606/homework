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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Work_Calculator
{
    public partial class PictureViewer : Form
    {
        public PictureViewer()
        {
            InitializeComponent();

            // 設置主畫面的縮圖列表
            pictureBox1.Image = Properties.Resources.a1544f;
            //pictureBox1.Tag = "a1544f";
            pictureBox2.Image = Properties.Resources.cat;
            //pictureBox2.Tag = "cat";
            pictureBox3.Image = Properties.Resources.Sprigatito;
            //pictureBox3.Tag = "Sprigatito";
            pictureBox4.Image = Properties.Resources.magnamalo;
            //pictureBox4.Tag = "magnamalo";
            pictureBox5.Image = Properties.Resources.monster01;
            //pictureBox5.Tag = "monster01";
            pictureBox6.Image = Properties.Resources.monster29;
            //pictureBox6.Tag = "monster29";
        }

        private void ShowImage(Image image)
        {            
            var form = new Form(); 
            //form.Text = image.Tag?.ToString();  // 設定Form的Title為圖片檔名 可以判斷 image.Tag 是否為 null          
            var pictureBox = new PictureBox();  // 建立新的PictureBox物件            
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // 設定PictureBox的SizeMode為Zoom            
            pictureBox.Dock = DockStyle.Fill;  // 設定PictureBox的Dock為Fill，讓圖片自動填滿整個Form            
            pictureBox.Image = image;  // 設定PictureBox的Image屬性為傳入的圖片                                       
            form.Controls.Add(pictureBox);  // 將PictureBox加入到Form中            
            form.ClientSize = image.Size;  // 設定Form的Size為圖片的Size            
            form.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowImage(Properties.Resources.a1544f);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowImage(Properties.Resources.cat);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowImage(Properties.Resources.Sprigatito);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowImage(Properties.Resources.magnamalo);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowImage(Properties.Resources.monster01);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowImage(Properties.Resources.monster29);
        }

        
    }
}
