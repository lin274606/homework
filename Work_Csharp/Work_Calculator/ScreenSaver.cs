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
    public partial class ScreenSaver : Form
    {
        public ScreenSaver()
        {
            InitializeComponent();
        }
        private Point lastMousePos;
        private void ScreenSaver_Load(object sender, EventArgs e)
        {
            pcbEevee.Location = new Point(12, 12);
            lastMousePos = Cursor.Position;
        }
        private void ScreenSaver_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Properties.Resources.a1544f, pcbEevee.Location);
        }                
        private void ScreenSaver_MouseMove(object sender, MouseEventArgs e)
        {            
            if (lastMousePos != e.Location)
            {
                this.Close();
            }           
        }

        private void ScreenSaver_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private int vx = 5;
        private int vy = 3;
        private void timer1_Tick(object sender, EventArgs e)
        {
            pcbEevee.Location = new Point(pcbEevee.Location.X + vx, pcbEevee.Location.Y + vy);
            if (pcbEevee.Location.X < 0 || pcbEevee.Location.X + pcbEevee.Width > this.Width)
            {
                vx = -vx;
            }
            if (pcbEevee.Location.Y < 0 || pcbEevee.Location.Y + pcbEevee.Height > this.Height)
            {
                vy = -vy;
            }
            this.Invalidate();
        }
    }
}
