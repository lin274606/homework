namespace Work_Calculator
{
    partial class StudentGrade_List
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
            this.labStatistic = new System.Windows.Forms.Label();
            this.listScore = new System.Windows.Forms.ListView();
            this.StudentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ChineseScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.EnglishScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MathScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AverageScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.HighestScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LowestScore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnReset = new System.Windows.Forms.Button();
            this.btnStatistic = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labChinese = new System.Windows.Forms.Label();
            this.labEnglish = new System.Windows.Forms.Label();
            this.labMath = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.txtEnglish = new System.Windows.Forms.TextBox();
            this.txtMath = new System.Windows.Forms.TextBox();
            this.txtChinese = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.labSearch = new System.Windows.Forms.Label();
            this.txtRangeA = new System.Windows.Forms.TextBox();
            this.txtRangeB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnRandom20 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labStatistic
            // 
            this.labStatistic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labStatistic.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStatistic.Location = new System.Drawing.Point(248, 288);
            this.labStatistic.Name = "labStatistic";
            this.labStatistic.Size = new System.Drawing.Size(559, 150);
            this.labStatistic.TabIndex = 37;
            // 
            // listScore
            // 
            this.listScore.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentName,
            this.ChineseScore,
            this.EnglishScore,
            this.MathScore,
            this.TotalScore,
            this.AverageScore,
            this.HighestScore,
            this.LowestScore});
            this.listScore.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.listScore.FullRowSelect = true;
            this.listScore.GridLines = true;
            this.listScore.HideSelection = false;
            this.listScore.Location = new System.Drawing.Point(248, 12);
            this.listScore.Name = "listScore";
            this.listScore.Size = new System.Drawing.Size(559, 270);
            this.listScore.TabIndex = 36;
            this.listScore.UseCompatibleStateImageBehavior = false;
            this.listScore.View = System.Windows.Forms.View.Details;
            // 
            // StudentName
            // 
            this.StudentName.Text = "姓名";
            this.StudentName.Width = 89;
            // 
            // ChineseScore
            // 
            this.ChineseScore.Text = "國文";
            this.ChineseScore.Width = 59;
            // 
            // EnglishScore
            // 
            this.EnglishScore.Text = "英文";
            this.EnglishScore.Width = 55;
            // 
            // MathScore
            // 
            this.MathScore.Text = "數學";
            this.MathScore.Width = 55;
            // 
            // TotalScore
            // 
            this.TotalScore.Text = "總分";
            // 
            // AverageScore
            // 
            this.AverageScore.Text = "平均";
            // 
            // HighestScore
            // 
            this.HighestScore.Text = "最高分";
            this.HighestScore.Width = 71;
            // 
            // LowestScore
            // 
            this.LowestScore.Text = "最低分";
            this.LowestScore.Width = 75;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReset.Location = new System.Drawing.Point(18, 497);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(149, 37);
            this.btnReset.TabIndex = 35;
            this.btnReset.Text = "重設";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnStatistic
            // 
            this.btnStatistic.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStatistic.Location = new System.Drawing.Point(18, 452);
            this.btnStatistic.Name = "btnStatistic";
            this.btnStatistic.Size = new System.Drawing.Size(149, 37);
            this.btnStatistic.TabIndex = 33;
            this.btnStatistic.Text = "各科統計";
            this.btnStatistic.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(18, 280);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(149, 37);
            this.btnAdd.TabIndex = 31;
            this.btnAdd.Text = "加入資料";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labChinese
            // 
            this.labChinese.AutoSize = true;
            this.labChinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labChinese.Location = new System.Drawing.Point(14, 91);
            this.labChinese.Name = "labChinese";
            this.labChinese.Size = new System.Drawing.Size(48, 24);
            this.labChinese.TabIndex = 30;
            this.labChinese.Text = "國文";
            // 
            // labEnglish
            // 
            this.labEnglish.AutoSize = true;
            this.labEnglish.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labEnglish.Location = new System.Drawing.Point(14, 152);
            this.labEnglish.Name = "labEnglish";
            this.labEnglish.Size = new System.Drawing.Size(48, 24);
            this.labEnglish.TabIndex = 29;
            this.labEnglish.Text = "英文";
            // 
            // labMath
            // 
            this.labMath.AutoSize = true;
            this.labMath.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMath.Location = new System.Drawing.Point(14, 216);
            this.labMath.Name = "labMath";
            this.labMath.Size = new System.Drawing.Size(48, 24);
            this.labMath.TabIndex = 28;
            this.labMath.Text = "數學";
            // 
            // labName
            // 
            this.labName.AutoSize = true;
            this.labName.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labName.Location = new System.Drawing.Point(14, 36);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(48, 24);
            this.labName.TabIndex = 27;
            this.labName.Text = "姓名";
            // 
            // txtEnglish
            // 
            this.txtEnglish.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtEnglish.Location = new System.Drawing.Point(68, 152);
            this.txtEnglish.Name = "txtEnglish";
            this.txtEnglish.Size = new System.Drawing.Size(99, 35);
            this.txtEnglish.TabIndex = 26;
            // 
            // txtMath
            // 
            this.txtMath.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMath.Location = new System.Drawing.Point(68, 216);
            this.txtMath.Name = "txtMath";
            this.txtMath.Size = new System.Drawing.Size(99, 35);
            this.txtMath.TabIndex = 25;
            // 
            // txtChinese
            // 
            this.txtChinese.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtChinese.Location = new System.Drawing.Point(68, 91);
            this.txtChinese.Name = "txtChinese";
            this.txtChinese.Size = new System.Drawing.Size(99, 35);
            this.txtChinese.TabIndex = 24;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName.Location = new System.Drawing.Point(68, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(99, 35);
            this.txtName.TabIndex = 23;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsert.Location = new System.Drawing.Point(18, 323);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(149, 37);
            this.btnInsert.TabIndex = 38;
            this.btnInsert.Text = "插入資料";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRemove.Location = new System.Drawing.Point(18, 366);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(149, 37);
            this.btnRemove.TabIndex = 39;
            this.btnRemove.Text = "移除資料";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // labSearch
            // 
            this.labSearch.AutoSize = true;
            this.labSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labSearch.Location = new System.Drawing.Point(244, 451);
            this.labSearch.Name = "labSearch";
            this.labSearch.Size = new System.Drawing.Size(162, 24);
            this.labSearch.TabIndex = 40;
            this.labSearch.Text = "搜尋國文成績範圍";
            // 
            // txtRangeA
            // 
            this.txtRangeA.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRangeA.Location = new System.Drawing.Point(248, 488);
            this.txtRangeA.Name = "txtRangeA";
            this.txtRangeA.Size = new System.Drawing.Size(48, 35);
            this.txtRangeA.TabIndex = 41;
            // 
            // txtRangeB
            // 
            this.txtRangeB.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRangeB.Location = new System.Drawing.Point(352, 488);
            this.txtRangeB.Name = "txtRangeB";
            this.txtRangeB.Size = new System.Drawing.Size(44, 35);
            this.txtRangeB.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(314, 497);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 24);
            this.label1.TabIndex = 43;
            this.label1.Text = "~";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(248, 540);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(149, 37);
            this.btnSearch.TabIndex = 44;
            this.btnSearch.Text = "搜尋";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnRandom20
            // 
            this.btnRandom20.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom20.Location = new System.Drawing.Point(18, 409);
            this.btnRandom20.Name = "btnRandom20";
            this.btnRandom20.Size = new System.Drawing.Size(149, 37);
            this.btnRandom20.TabIndex = 45;
            this.btnRandom20.Text = "隨機加入20筆";
            this.btnRandom20.UseVisualStyleBackColor = true;
            this.btnRandom20.Click += new System.EventHandler(this.btnRandom20_Click);
            // 
            // StudentGrade_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 589);
            this.Controls.Add(this.btnRandom20);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRangeB);
            this.Controls.Add(this.txtRangeA);
            this.Controls.Add(this.labSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.labStatistic);
            this.Controls.Add(this.listScore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnStatistic);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labChinese);
            this.Controls.Add(this.labEnglish);
            this.Controls.Add(this.labMath);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.txtEnglish);
            this.Controls.Add(this.txtMath);
            this.Controls.Add(this.txtChinese);
            this.Controls.Add(this.txtName);
            this.Name = "StudentGrade_List";
            this.Text = "StudentGrade_List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labStatistic;
        private System.Windows.Forms.ListView listScore;
        private System.Windows.Forms.ColumnHeader StudentName;
        private System.Windows.Forms.ColumnHeader ChineseScore;
        private System.Windows.Forms.ColumnHeader EnglishScore;
        private System.Windows.Forms.ColumnHeader MathScore;
        private System.Windows.Forms.ColumnHeader TotalScore;
        private System.Windows.Forms.ColumnHeader AverageScore;
        private System.Windows.Forms.ColumnHeader HighestScore;
        private System.Windows.Forms.ColumnHeader LowestScore;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnStatistic;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labChinese;
        private System.Windows.Forms.Label labEnglish;
        private System.Windows.Forms.Label labMath;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.TextBox txtEnglish;
        private System.Windows.Forms.TextBox txtMath;
        private System.Windows.Forms.TextBox txtChinese;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label labSearch;
        private System.Windows.Forms.TextBox txtRangeA;
        private System.Windows.Forms.TextBox txtRangeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnRandom20;
    }
}