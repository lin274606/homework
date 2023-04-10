namespace Lab_Form
{
    partial class Form_M32_String
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
            this.btnString = new System.Windows.Forms.Button();
            this.btnStringBulider = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPW = new System.Windows.Forms.TextBox();
            this.labID = new System.Windows.Forms.Label();
            this.labPW = new System.Windows.Forms.Label();
            this.labValidID = new System.Windows.Forms.Label();
            this.labVaildPW = new System.Windows.Forms.Label();
            this.btnIsValid = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnString
            // 
            this.btnString.Location = new System.Drawing.Point(31, 36);
            this.btnString.Name = "btnString";
            this.btnString.Size = new System.Drawing.Size(172, 52);
            this.btnString.TabIndex = 0;
            this.btnString.Text = "string";
            this.btnString.UseVisualStyleBackColor = true;
            this.btnString.Click += new System.EventHandler(this.btnString_Click);
            // 
            // btnStringBulider
            // 
            this.btnStringBulider.Location = new System.Drawing.Point(31, 118);
            this.btnStringBulider.Name = "btnStringBulider";
            this.btnStringBulider.Size = new System.Drawing.Size(172, 52);
            this.btnStringBulider.TabIndex = 1;
            this.btnStringBulider.Text = "stringbulider";
            this.btnStringBulider.UseVisualStyleBackColor = true;
            this.btnStringBulider.Click += new System.EventHandler(this.btnStringBulider_Click);
            // 
            // btnPath
            // 
            this.btnPath.Location = new System.Drawing.Point(31, 201);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(172, 52);
            this.btnPath.TabIndex = 2;
            this.btnPath.Text = "Path";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtID.Location = new System.Drawing.Point(357, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(184, 33);
            this.txtID.TabIndex = 3;
            // 
            // txtPW
            // 
            this.txtPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPW.Location = new System.Drawing.Point(357, 106);
            this.txtPW.Name = "txtPW";
            this.txtPW.Size = new System.Drawing.Size(184, 33);
            this.txtPW.TabIndex = 4;
            // 
            // labID
            // 
            this.labID.AutoSize = true;
            this.labID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labID.Location = new System.Drawing.Point(231, 47);
            this.labID.Name = "labID";
            this.labID.Size = new System.Drawing.Size(109, 24);
            this.labID.TabIndex = 5;
            this.labID.Text = "身分證字號:";
            // 
            // labPW
            // 
            this.labPW.AutoSize = true;
            this.labPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPW.Location = new System.Drawing.Point(288, 109);
            this.labPW.Name = "labPW";
            this.labPW.Size = new System.Drawing.Size(52, 24);
            this.labPW.TabIndex = 6;
            this.labPW.Text = "密碼:";
            // 
            // labValidID
            // 
            this.labValidID.AutoSize = true;
            this.labValidID.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labValidID.Location = new System.Drawing.Point(570, 44);
            this.labValidID.Name = "labValidID";
            this.labValidID.Size = new System.Drawing.Size(105, 24);
            this.labValidID.TabIndex = 7;
            this.labValidID.Text = "身分證驗證";
            // 
            // labVaildPW
            // 
            this.labVaildPW.AutoSize = true;
            this.labVaildPW.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labVaildPW.Location = new System.Drawing.Point(570, 109);
            this.labVaildPW.Name = "labVaildPW";
            this.labVaildPW.Size = new System.Drawing.Size(86, 24);
            this.labVaildPW.TabIndex = 8;
            this.labVaildPW.Text = "密碼驗證";
            // 
            // btnIsValid
            // 
            this.btnIsValid.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIsValid.Location = new System.Drawing.Point(444, 179);
            this.btnIsValid.Name = "btnIsValid";
            this.btnIsValid.Size = new System.Drawing.Size(97, 52);
            this.btnIsValid.TabIndex = 9;
            this.btnIsValid.Text = "驗證";
            this.btnIsValid.UseVisualStyleBackColor = true;
            this.btnIsValid.Click += new System.EventHandler(this.btnIsValid_Click);
            // 
            // Form_M32_String
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIsValid);
            this.Controls.Add(this.labVaildPW);
            this.Controls.Add(this.labValidID);
            this.Controls.Add(this.labPW);
            this.Controls.Add(this.labID);
            this.Controls.Add(this.txtPW);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnStringBulider);
            this.Controls.Add(this.btnString);
            this.Name = "Form_M32_String";
            this.Text = "Form_M32_String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnString;
        private System.Windows.Forms.Button btnStringBulider;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPW;
        private System.Windows.Forms.Label labID;
        private System.Windows.Forms.Label labPW;
        private System.Windows.Forms.Label labValidID;
        private System.Windows.Forms.Label labVaildPW;
        private System.Windows.Forms.Button btnIsValid;
    }
}