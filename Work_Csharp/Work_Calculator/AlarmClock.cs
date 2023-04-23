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
    public partial class AlarmClock : Form
    {
        public AlarmClock()
        {
            InitializeComponent(); 
        }
        private void AlarmClock_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer
            {
                Interval = 1000
            };
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            PickerAlarm.Value = DateTime.Now;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            labCurrentTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void cheAlarm_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cheAlarm.Checked)
                {
                    DateTime alarmTime = DateTime.Parse(PickerAlarm.Text);
                    TimeSpan timeSpan = alarmTime - DateTime.Now;

                    timerAlarm.Interval = (int)timeSpan.TotalMilliseconds;
                    timerAlarm.Start();
                }               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出現{ex}狀況");
            }
            
        }

        private void timerAlarm_Tick(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.Now >= DateTime.Parse(PickerAlarm.Text))
                {
                    timerBlink.Enabled = true;
                    timerAlarm.Stop();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"出現{ex}狀況");
            }
           
        }        

        private void timerBlink_Tick(object sender, EventArgs e)
        {            
            int r = (labAlarm.ForeColor.R + 50) % 256;
            int g = (labAlarm.ForeColor.G + 20) % 256;
            int b = (labAlarm.ForeColor.B + 10) % 256;
            labAlarm.ForeColor = Color.FromArgb(r, g, b);
        }

        
    }
}
