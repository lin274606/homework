namespace Lab_Form
{
    partial class Form_M02_HelloForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_M02_HelloForm));
            this.btnName = new System.Windows.Forms.Button();
            this.labName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.labENname = new System.Windows.Forms.Label();
            this.txtENname = new System.Windows.Forms.TextBox();
            this.txtZodiac = new System.Windows.Forms.TextBox();
            this.Zodiac = new System.Windows.Forms.Label();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.Gender = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(393, 383);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(299, 56);
            this.btnName.TabIndex = 0;
            this.btnName.Text = "Say Hello";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(434, 40);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(75, 34);
            this.labName.TabIndex = 1;
            this.labName.Text = "姓名:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(545, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(130, 43);
            this.txtName.TabIndex = 2;
            // 
            // labENname
            // 
            this.labENname.AutoSize = true;
            this.labENname.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labENname.Location = new System.Drawing.Point(324, 123);
            this.labENname.Name = "labENname";
            this.labENname.Size = new System.Drawing.Size(195, 34);
            this.labENname.TabIndex = 3;
            this.labENname.Text = "English Name:";
            // 
            // txtENname
            // 
            this.txtENname.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtENname.Location = new System.Drawing.Point(545, 123);
            this.txtENname.Name = "txtENname";
            this.txtENname.Size = new System.Drawing.Size(130, 43);
            this.txtENname.TabIndex = 4;
            // 
            // txtZodiac
            // 
            this.txtZodiac.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtZodiac.Location = new System.Drawing.Point(545, 284);
            this.txtZodiac.Name = "txtZodiac";
            this.txtZodiac.Size = new System.Drawing.Size(130, 43);
            this.txtZodiac.TabIndex = 8;
            // 
            // Zodiac
            // 
            this.Zodiac.AutoSize = true;
            this.Zodiac.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Zodiac.Location = new System.Drawing.Point(434, 284);
            this.Zodiac.Name = "Zodiac";
            this.Zodiac.Size = new System.Drawing.Size(75, 34);
            this.Zodiac.TabIndex = 7;
            this.Zodiac.Text = "星座:";
            // 
            // txtGender
            // 
            this.txtGender.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtGender.Location = new System.Drawing.Point(545, 201);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(130, 43);
            this.txtGender.TabIndex = 6;
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Gender.Location = new System.Drawing.Point(434, 201);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(75, 34);
            this.Gender.TabIndex = 5;
            this.Gender.Text = "性別:";
            // 
            // Form_M02_HelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 462);
            this.Controls.Add(this.txtZodiac);
            this.Controls.Add(this.Zodiac);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.txtENname);
            this.Controls.Add(this.labENname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.btnName);
            this.Name = "Form_M02_HelloForm";
            this.Text = "Hello Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label labENname;
        private System.Windows.Forms.TextBox txtENname;
        private System.Windows.Forms.TextBox txtZodiac;
        private System.Windows.Forms.Label Zodiac;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.Label Gender;
    }
}

