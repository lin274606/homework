namespace Work_Calculator
{
    partial class AlarmClock
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerAlarm = new System.Windows.Forms.Timer(this.components);
            this.cheAlarm = new System.Windows.Forms.CheckBox();
            this.labCurrentTime = new System.Windows.Forms.Label();
            this.labAlarm = new System.Windows.Forms.Label();
            this.timerBlink = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PickerAlarm = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // timerAlarm
            // 
            this.timerAlarm.Tick += new System.EventHandler(this.timerAlarm_Tick);
            // 
            // cheAlarm
            // 
            this.cheAlarm.AutoSize = true;
            this.cheAlarm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cheAlarm.ForeColor = System.Drawing.Color.White;
            this.cheAlarm.Location = new System.Drawing.Point(75, 313);
            this.cheAlarm.Name = "cheAlarm";
            this.cheAlarm.Size = new System.Drawing.Size(127, 31);
            this.cheAlarm.TabIndex = 1;
            this.cheAlarm.Text = "Set Alarm";
            this.cheAlarm.UseVisualStyleBackColor = true;
            this.cheAlarm.CheckedChanged += new System.EventHandler(this.cheAlarm_CheckedChanged);
            // 
            // labCurrentTime
            // 
            this.labCurrentTime.BackColor = System.Drawing.Color.Transparent;
            this.labCurrentTime.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCurrentTime.ForeColor = System.Drawing.Color.White;
            this.labCurrentTime.Location = new System.Drawing.Point(42, 50);
            this.labCurrentTime.Name = "labCurrentTime";
            this.labCurrentTime.Size = new System.Drawing.Size(193, 47);
            this.labCurrentTime.TabIndex = 2;
            this.labCurrentTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labAlarm
            // 
            this.labAlarm.AutoSize = true;
            this.labAlarm.BackColor = System.Drawing.Color.Transparent;
            this.labAlarm.Font = new System.Drawing.Font("微軟正黑體", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labAlarm.ForeColor = System.Drawing.Color.Black;
            this.labAlarm.Location = new System.Drawing.Point(41, 136);
            this.labAlarm.Name = "labAlarm";
            this.labAlarm.Size = new System.Drawing.Size(194, 45);
            this.labAlarm.TabIndex = 3;
            this.labAlarm.Text = "時間到了!!";
            this.labAlarm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBlink
            // 
            this.timerBlink.Tick += new System.EventHandler(this.timerBlink_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PickerAlarm
            // 
            this.PickerAlarm.CalendarFont = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PickerAlarm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PickerAlarm.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.PickerAlarm.Location = new System.Drawing.Point(41, 262);
            this.PickerAlarm.Name = "PickerAlarm";
            this.PickerAlarm.Size = new System.Drawing.Size(194, 35);
            this.PickerAlarm.TabIndex = 4;
            this.PickerAlarm.Value = new System.DateTime(2023, 4, 21, 15, 20, 0, 0);
            // 
            // AlarmClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(283, 393);
            this.Controls.Add(this.PickerAlarm);
            this.Controls.Add(this.labAlarm);
            this.Controls.Add(this.labCurrentTime);
            this.Controls.Add(this.cheAlarm);
            this.Name = "AlarmClock";
            this.Text = "AlarmClock";
            this.Load += new System.EventHandler(this.AlarmClock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timerAlarm;
        private System.Windows.Forms.CheckBox cheAlarm;
        private System.Windows.Forms.Label labCurrentTime;
        private System.Windows.Forms.Label labAlarm;
        private System.Windows.Forms.Timer timerBlink;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DateTimePicker PickerAlarm;
    }
}