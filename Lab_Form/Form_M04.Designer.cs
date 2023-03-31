namespace Lab_Form
{
    partial class Form_M04
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
            this.OpenHelloForm = new System.Windows.Forms.Button();
            this.btnMethod = new System.Windows.Forms.Button();
            this.btnReturnMethod = new System.Windows.Forms.Button();
            this.btnMyclass = new System.Windows.Forms.Button();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnPartialClass = new System.Windows.Forms.Button();
            this.btnNewMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OpenHelloForm
            // 
            this.OpenHelloForm.Location = new System.Drawing.Point(383, 12);
            this.OpenHelloForm.Name = "OpenHelloForm";
            this.OpenHelloForm.Size = new System.Drawing.Size(246, 37);
            this.OpenHelloForm.TabIndex = 0;
            this.OpenHelloForm.Text = "Open Hello Form";
            this.OpenHelloForm.UseVisualStyleBackColor = true;
            this.OpenHelloForm.Click += new System.EventHandler(this.OpenHelloForm_Click);
            // 
            // btnMethod
            // 
            this.btnMethod.Location = new System.Drawing.Point(471, 64);
            this.btnMethod.Name = "btnMethod";
            this.btnMethod.Size = new System.Drawing.Size(148, 27);
            this.btnMethod.TabIndex = 1;
            this.btnMethod.Text = "Method";
            this.btnMethod.UseVisualStyleBackColor = true;
            this.btnMethod.Click += new System.EventHandler(this.btnMethod_Click);
            // 
            // btnReturnMethod
            // 
            this.btnReturnMethod.Location = new System.Drawing.Point(443, 108);
            this.btnReturnMethod.Name = "btnReturnMethod";
            this.btnReturnMethod.Size = new System.Drawing.Size(176, 25);
            this.btnReturnMethod.TabIndex = 2;
            this.btnReturnMethod.Text = "Return Method";
            this.btnReturnMethod.UseVisualStyleBackColor = true;
            this.btnReturnMethod.Click += new System.EventHandler(this.btnReturnMethod_Click);
            // 
            // btnMyclass
            // 
            this.btnMyclass.Location = new System.Drawing.Point(462, 159);
            this.btnMyclass.Name = "btnMyclass";
            this.btnMyclass.Size = new System.Drawing.Size(157, 27);
            this.btnMyclass.TabIndex = 3;
            this.btnMyclass.Text = "My class";
            this.btnMyclass.UseVisualStyleBackColor = true;
            this.btnMyclass.Click += new System.EventHandler(this.btnMyclass_Click);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(319, 108);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(100, 22);
            this.txtAge.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(462, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "封裝";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPartialClass
            // 
            this.btnPartialClass.Location = new System.Drawing.Point(462, 268);
            this.btnPartialClass.Name = "btnPartialClass";
            this.btnPartialClass.Size = new System.Drawing.Size(157, 42);
            this.btnPartialClass.TabIndex = 6;
            this.btnPartialClass.Text = "Partial Class";
            this.btnPartialClass.UseVisualStyleBackColor = true;
            this.btnPartialClass.Click += new System.EventHandler(this.btnPartialClass_Click);
            // 
            // btnNewMember
            // 
            this.btnNewMember.Location = new System.Drawing.Point(462, 334);
            this.btnNewMember.Name = "btnNewMember";
            this.btnNewMember.Size = new System.Drawing.Size(157, 42);
            this.btnNewMember.TabIndex = 7;
            this.btnNewMember.Text = "New Member";
            this.btnNewMember.UseVisualStyleBackColor = true;
            this.btnNewMember.Click += new System.EventHandler(this.btnNewMember_Click);
            // 
            // Form_M04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewMember);
            this.Controls.Add(this.btnPartialClass);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnMyclass);
            this.Controls.Add(this.btnReturnMethod);
            this.Controls.Add(this.btnMethod);
            this.Controls.Add(this.OpenHelloForm);
            this.Name = "Form_M04";
            this.Text = "Form_M04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenHelloForm;
        private System.Windows.Forms.Button btnMethod;
        private System.Windows.Forms.Button btnReturnMethod;
        private System.Windows.Forms.Button btnMyclass;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnPartialClass;
        private System.Windows.Forms.Button btnNewMember;
    }
}