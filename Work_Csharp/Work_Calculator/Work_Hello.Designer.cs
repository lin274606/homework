namespace Work_Calculator
{
    partial class Work_Hello
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Work_Hello));
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtENName = new System.Windows.Forms.TextBox();
            this.labENName = new System.Windows.Forms.Label();
            this.txtZodiac = new System.Windows.Forms.TextBox();
            this.labZodiac = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.labGender = new System.Windows.Forms.Label();
            this.btnHello = new System.Windows.Forms.Button();
            this.btnHi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(421, 60);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(59, 27);
            this.labName.TabIndex = 0;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(552, 60);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 35);
            this.txtName.TabIndex = 1;
            // 
            // txtENName
            // 
            this.txtENName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtENName.Location = new System.Drawing.Point(552, 131);
            this.txtENName.Name = "txtENName";
            this.txtENName.Size = new System.Drawing.Size(128, 35);
            this.txtENName.TabIndex = 3;
            // 
            // labENName
            // 
            this.labENName.AutoSize = true;
            this.labENName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labENName.Location = new System.Drawing.Point(361, 131);
            this.labENName.Name = "labENName";
            this.labENName.Size = new System.Drawing.Size(152, 27);
            this.labENName.TabIndex = 2;
            this.labENName.Text = "English Name:";
            // 
            // txtZodiac
            // 
            this.txtZodiac.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtZodiac.Location = new System.Drawing.Point(552, 207);
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(128, 35);
            this.txtZodiac.TabIndex = 5;
            // 
            // labZodiac
            // 
            this.labZodiac.AutoSize = true;
            this.labZodiac.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labZodiac.Location = new System.Drawing.Point(421, 207);
            this.labZodiac.Name = "labZodiac";
            this.labZodiac.Size = new System.Drawing.Size(59, 27);
            this.labZodiac.TabIndex = 4;
            this.labZodiac.Text = "星座:";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(552, 278);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(128, 35);
            this.txtGender.TabIndex = 7;
            // 
            // labGender
            // 
            this.labGender.AutoSize = true;
            this.labGender.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGender.Location = new System.Drawing.Point(421, 278);
            this.labGender.Name = "labGender";
            this.labGender.Size = new System.Drawing.Size(59, 27);
            this.labGender.TabIndex = 6;
            this.labGender.Text = "性別:";
            // 
            // btnHello
            // 
            this.btnHello.AutoSize = true;
            this.btnHello.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHello.Location = new System.Drawing.Point(367, 356);
            this.btnHello.Name = "btnHello";
            this.btnHello.Size = new System.Drawing.Size(113, 37);
            this.btnHello.TabIndex = 8;
            this.btnHello.Text = "Say Hello";
            this.btnHello.UseVisualStyleBackColor = true;
            this.btnHello.Click += new System.EventHandler(this.btnHello_Click);
            // 
            // btnHi
            // 
            this.btnHi.AutoSize = true;
            this.btnHi.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnHi.Location = new System.Drawing.Point(546, 356);
            this.btnHi.Name = "btnHi";
            this.btnHi.Size = new System.Drawing.Size(113, 37);
            this.btnHi.TabIndex = 9;
            this.btnHi.Text = "Say Hi";
            this.btnHi.UseVisualStyleBackColor = true;
            this.btnHi.Click += new System.EventHandler(this.btnHi_Click);
            // 
            // Work_Hello
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(702, 464);
            this.Controls.Add(this.btnHi);
            this.Controls.Add(this.btnHello);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.labGender);
            this.Controls.Add(this.txtZodiac);
            this.Controls.Add(this.labZodiac);
            this.Controls.Add(this.txtENName);
            this.Controls.Add(this.labENName);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Name = "Work_Hello";
            this.Text = "你好 C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtENName;
        private System.Windows.Forms.Label labENName;
        private System.Windows.Forms.TextBox txtZodiac;
        private System.Windows.Forms.Label labZodiac;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label labGender;
        private System.Windows.Forms.Button btnHello;
        private System.Windows.Forms.Button btnHi;
    }
}