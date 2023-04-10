namespace Lab_Form
{
    partial class Form_M26_array
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
            this.btnArray = new System.Windows.Forms.Button();
            this.btn2Darray = new System.Windows.Forms.Button();
            this.btnArrMember = new System.Windows.Forms.Button();
            this.btnMethodArray = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnArray
            // 
            this.btnArray.Location = new System.Drawing.Point(55, 38);
            this.btnArray.Name = "btnArray";
            this.btnArray.Size = new System.Drawing.Size(165, 47);
            this.btnArray.TabIndex = 0;
            this.btnArray.Text = "array";
            this.btnArray.UseVisualStyleBackColor = true;
            this.btnArray.Click += new System.EventHandler(this.btnArray_Click);
            // 
            // btn2Darray
            // 
            this.btn2Darray.Location = new System.Drawing.Point(55, 104);
            this.btn2Darray.Name = "btn2Darray";
            this.btn2Darray.Size = new System.Drawing.Size(165, 47);
            this.btn2Darray.TabIndex = 1;
            this.btn2Darray.Text = "2Darray";
            this.btn2Darray.UseVisualStyleBackColor = true;
            this.btn2Darray.Click += new System.EventHandler(this.btn2Darray_Click);
            // 
            // btnArrMember
            // 
            this.btnArrMember.Location = new System.Drawing.Point(55, 176);
            this.btnArrMember.Name = "btnArrMember";
            this.btnArrMember.Size = new System.Drawing.Size(165, 47);
            this.btnArrMember.TabIndex = 2;
            this.btnArrMember.Text = "member array";
            this.btnArrMember.UseVisualStyleBackColor = true;
            this.btnArrMember.Click += new System.EventHandler(this.btnArrMember_Click);
            // 
            // btnMethodArray
            // 
            this.btnMethodArray.Location = new System.Drawing.Point(55, 249);
            this.btnMethodArray.Name = "btnMethodArray";
            this.btnMethodArray.Size = new System.Drawing.Size(165, 47);
            this.btnMethodArray.TabIndex = 3;
            this.btnMethodArray.Text = "傳回陣列的方法";
            this.btnMethodArray.UseVisualStyleBackColor = true;
            this.btnMethodArray.Click += new System.EventHandler(this.btnMethodArray_Click);
            // 
            // Form_M26_array
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMethodArray);
            this.Controls.Add(this.btnArrMember);
            this.Controls.Add(this.btn2Darray);
            this.Controls.Add(this.btnArray);
            this.Name = "Form_M26_array";
            this.Text = "Form_M26_array";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArray;
        private System.Windows.Forms.Button btn2Darray;
        private System.Windows.Forms.Button btnArrMember;
        private System.Windows.Forms.Button btnMethodArray;
    }
}