namespace Lab_Form
{
    partial class Form_M12
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
            this.labCount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnNum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Var = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.labStatic = new System.Windows.Forms.Label();
            this.labInstance = new System.Windows.Forms.Label();
            this.Var.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labCount.Location = new System.Drawing.Point(56, 61);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(89, 30);
            this.labCount.TabIndex = 0;
            this.labCount.Text = "Count:";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAdd.Location = new System.Drawing.Point(32, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 53);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "*=";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnNum
            // 
            this.btnNum.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnNum.Location = new System.Drawing.Point(32, 233);
            this.btnNum.Name = "btnNum";
            this.btnNum.Size = new System.Drawing.Size(150, 53);
            this.btnNum.TabIndex = 2;
            this.btnNum.Text = "++num";
            this.btnNum.UseVisualStyleBackColor = true;
            this.btnNum.Click += new System.EventHandler(this.btnNum_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(32, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 53);
            this.button1.TabIndex = 3;
            this.button1.Text = "num++";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Var
            // 
            this.Var.Controls.Add(this.button3);
            this.Var.Controls.Add(this.button2);
            this.Var.Location = new System.Drawing.Point(229, 12);
            this.Var.Name = "Var";
            this.Var.Size = new System.Drawing.Size(193, 197);
            this.Var.TabIndex = 4;
            this.Var.TabStop = false;
            this.Var.Text = "groupBox1";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(25, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "Local Variable";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(25, 123);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 53);
            this.button3.TabIndex = 6;
            this.button3.Text = "Class Variable";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(229, 233);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 197);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button4.Location = new System.Drawing.Point(25, 123);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 53);
            this.button4.TabIndex = 6;
            this.button4.Text = "Instance Number";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button5.Location = new System.Drawing.Point(25, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(150, 53);
            this.button5.TabIndex = 5;
            this.button5.Text = "Static Number";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // labStatic
            // 
            this.labStatic.AutoSize = true;
            this.labStatic.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labStatic.Location = new System.Drawing.Point(454, 288);
            this.labStatic.Name = "labStatic";
            this.labStatic.Size = new System.Drawing.Size(155, 27);
            this.labStatic.TabIndex = 8;
            this.labStatic.Text = "Static Count: 0";
            // 
            // labInstance
            // 
            this.labInstance.AutoSize = true;
            this.labInstance.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labInstance.Location = new System.Drawing.Point(454, 367);
            this.labInstance.Name = "labInstance";
            this.labInstance.Size = new System.Drawing.Size(184, 27);
            this.labInstance.TabIndex = 9;
            this.labInstance.Text = "Instance Count: 0";
            // 
            // Form_M12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labInstance);
            this.Controls.Add(this.labStatic);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Var);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNum);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labCount);
            this.Name = "Form_M12";
            this.Text = "Form_M12";
            this.Var.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox Var;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label labStatic;
        private System.Windows.Forms.Label labInstance;
    }
}