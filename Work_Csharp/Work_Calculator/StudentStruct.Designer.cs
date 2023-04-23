namespace Work_Struct
{
    partial class StudentStruct
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.labName = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labChinese = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.gpbScore = new System.Windows.Forms.GroupBox();
            this.labMaxMin = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnMaxMin = new System.Windows.Forms.Button();
            this.gpbScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(151, 45);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(166, 35);
            this.txtName.TabIndex = 0;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(151, 115);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(166, 35);
            this.txtChinese.TabIndex = 1;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(151, 240);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(166, 35);
            this.txtMath.TabIndex = 2;
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(151, 176);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(166, 35);
            this.txtEnglish.TabIndex = 3;
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(48, 45);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 24);
            this.labName.TabIndex = 4;
            this.labName.Text = "姓名";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(48, 240);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(48, 24);
            this.labMath.TabIndex = 5;
            this.labMath.Text = "數學";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(48, 176);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(48, 24);
            this.labEnglish.TabIndex = 6;
            this.labEnglish.Text = "英文";
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(48, 115);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(48, 24);
            this.labChinese.TabIndex = 7;
            this.labChinese.Text = "國文";
            // 
            // btnSave
            // 
            this.btnSave.AutoSize = true;
            this.btnSave.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSave.Location = new System.Drawing.Point(52, 326);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 44);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "儲存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnList
            // 
            this.btnList.AutoSize = true;
            this.btnList.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnList.Location = new System.Drawing.Point(183, 326);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(134, 44);
            this.btnList.TabIndex = 9;
            this.btnList.Text = "顯示儲存內容";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // gpbScore
            // 
            this.gpbScore.Controls.Add(this.labMaxMin);
            this.gpbScore.Controls.Add(this.labList);
            this.gpbScore.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.gpbScore.Location = new System.Drawing.Point(430, 21);
            this.gpbScore.Name = "gpbScore";
            this.gpbScore.Size = new System.Drawing.Size(338, 336);
            this.gpbScore.TabIndex = 10;
            this.gpbScore.TabStop = false;
            this.gpbScore.Text = "成績";
            // 
            // labMaxMin
            // 
            this.labMaxMin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labMaxMin.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMaxMin.Location = new System.Drawing.Point(24, 194);
            this.labMaxMin.Name = "labMaxMin";
            this.labMaxMin.Size = new System.Drawing.Size(293, 120);
            this.labMaxMin.TabIndex = 1;
            // 
            // labList
            // 
            this.labList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(24, 29);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(293, 153);
            this.labList.TabIndex = 0;
            // 
            // btnReset
            // 
            this.btnReset.AutoSize = true;
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(430, 374);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(101, 44);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "清除";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnMaxMin
            // 
            this.btnMaxMin.AutoSize = true;
            this.btnMaxMin.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMaxMin.Location = new System.Drawing.Point(626, 374);
            this.btnMaxMin.Name = "btnMaxMin";
            this.btnMaxMin.Size = new System.Drawing.Size(142, 44);
            this.btnMaxMin.TabIndex = 12;
            this.btnMaxMin.Text = "最高分/最低分";
            this.btnMaxMin.UseVisualStyleBackColor = true;
            this.btnMaxMin.Click += new System.EventHandler(this.btnMaxMin_Click);
            // 
            // Struct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMaxMin);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.gpbScore);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Name = "Struct";
            this.Text = "Form1";
            this.gpbScore.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.GroupBox gpbScore;
        private System.Windows.Forms.Label labMaxMin;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnMaxMin;
    }
}

