namespace Lab_Form
{
    partial class Form_M21
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
            this.btn = new System.Windows.Forms.Button();
            this.btnGrade = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.labGrade = new System.Windows.Forms.Label();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDo = new System.Windows.Forms.Button();
            this.btnFor = new System.Windows.Forms.Button();
            this.btnForeach = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn
            // 
            this.btn.AutoSize = true;
            this.btn.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn.Location = new System.Drawing.Point(65, 59);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(127, 38);
            this.btn.TabIndex = 0;
            this.btn.Text = "三元運算式";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGrade
            // 
            this.btnGrade.AutoSize = true;
            this.btnGrade.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnGrade.Location = new System.Drawing.Point(257, 137);
            this.btnGrade.Name = "btnGrade";
            this.btnGrade.Size = new System.Drawing.Size(127, 38);
            this.btnGrade.TabIndex = 1;
            this.btnGrade.Text = "分級";
            this.btnGrade.UseVisualStyleBackColor = true;
            this.btnGrade.Click += new System.EventHandler(this.btnGrade_Click);
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtScore.Location = new System.Drawing.Point(247, 62);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(137, 35);
            this.txtScore.TabIndex = 2;
            // 
            // labGrade
            // 
            this.labGrade.AutoSize = true;
            this.labGrade.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labGrade.Location = new System.Drawing.Point(411, 70);
            this.labGrade.Name = "labGrade";
            this.labGrade.Size = new System.Drawing.Size(75, 27);
            this.labGrade.TabIndex = 3;
            this.labGrade.Text = "級數：";
            // 
            // btnSwitch
            // 
            this.btnSwitch.AutoSize = true;
            this.btnSwitch.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSwitch.Location = new System.Drawing.Point(65, 137);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(127, 38);
            this.btnSwitch.TabIndex = 4;
            this.btnSwitch.Text = "switch";
            this.btnSwitch.UseVisualStyleBackColor = true;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // btnWhile
            // 
            this.btnWhile.AutoSize = true;
            this.btnWhile.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhile.Location = new System.Drawing.Point(546, 59);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(127, 38);
            this.btnWhile.TabIndex = 5;
            this.btnWhile.Text = "while";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDo
            // 
            this.btnDo.AutoSize = true;
            this.btnDo.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnDo.Location = new System.Drawing.Point(546, 119);
            this.btnDo.Name = "btnDo";
            this.btnDo.Size = new System.Drawing.Size(127, 38);
            this.btnDo.TabIndex = 6;
            this.btnDo.Text = "do";
            this.btnDo.UseVisualStyleBackColor = true;
            this.btnDo.Click += new System.EventHandler(this.btnDo_Click);
            // 
            // btnFor
            // 
            this.btnFor.AutoSize = true;
            this.btnFor.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFor.Location = new System.Drawing.Point(546, 189);
            this.btnFor.Name = "btnFor";
            this.btnFor.Size = new System.Drawing.Size(127, 38);
            this.btnFor.TabIndex = 7;
            this.btnFor.Text = "for";
            this.btnFor.UseVisualStyleBackColor = true;
            this.btnFor.Click += new System.EventHandler(this.btnFor_Click);
            // 
            // btnForeach
            // 
            this.btnForeach.AutoSize = true;
            this.btnForeach.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnForeach.Location = new System.Drawing.Point(546, 266);
            this.btnForeach.Name = "btnForeach";
            this.btnForeach.Size = new System.Drawing.Size(127, 38);
            this.btnForeach.TabIndex = 8;
            this.btnForeach.Text = "foreach";
            this.btnForeach.UseVisualStyleBackColor = true;
            this.btnForeach.Click += new System.EventHandler(this.btnForeach_Click);
            // 
            // Form_M21
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnForeach);
            this.Controls.Add(this.btnFor);
            this.Controls.Add(this.btnDo);
            this.Controls.Add(this.btnWhile);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.labGrade);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnGrade);
            this.Controls.Add(this.btn);
            this.Name = "Form_M21";
            this.Text = "Form21";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnGrade;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Label labGrade;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDo;
        private System.Windows.Forms.Button btnFor;
        private System.Windows.Forms.Button btnForeach;
    }
}