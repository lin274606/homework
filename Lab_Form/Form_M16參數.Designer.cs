namespace Lab_Form
{
    partial class Form_M16參數
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
            this.btnByValue = new System.Windows.Forms.Button();
            this.btnByReference = new System.Windows.Forms.Button();
            this.btnByref = new System.Windows.Forms.Button();
            this.btnByOut = new System.Windows.Forms.Button();
            this.btnParams = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnByValue
            // 
            this.btnByValue.Location = new System.Drawing.Point(80, 26);
            this.btnByValue.Name = "btnByValue";
            this.btnByValue.Size = new System.Drawing.Size(122, 52);
            this.btnByValue.TabIndex = 0;
            this.btnByValue.Text = "By Value參數";
            this.btnByValue.UseVisualStyleBackColor = true;
            this.btnByValue.Click += new System.EventHandler(this.btnByValue_Click);
            // 
            // btnByReference
            // 
            this.btnByReference.Location = new System.Drawing.Point(80, 84);
            this.btnByReference.Name = "btnByReference";
            this.btnByReference.Size = new System.Drawing.Size(122, 52);
            this.btnByReference.TabIndex = 1;
            this.btnByReference.Text = "By Reference參數";
            this.btnByReference.UseVisualStyleBackColor = true;
            this.btnByReference.Click += new System.EventHandler(this.btnByReference_Click);
            // 
            // btnByref
            // 
            this.btnByref.Location = new System.Drawing.Point(80, 142);
            this.btnByref.Name = "btnByref";
            this.btnByref.Size = new System.Drawing.Size(122, 52);
            this.btnByref.TabIndex = 2;
            this.btnByref.Text = "By ref參數";
            this.btnByref.UseVisualStyleBackColor = true;
            this.btnByref.Click += new System.EventHandler(this.btnByref_Click);
            // 
            // btnByOut
            // 
            this.btnByOut.Location = new System.Drawing.Point(80, 200);
            this.btnByOut.Name = "btnByOut";
            this.btnByOut.Size = new System.Drawing.Size(122, 52);
            this.btnByOut.TabIndex = 3;
            this.btnByOut.Text = "By Out參數";
            this.btnByOut.UseVisualStyleBackColor = true;
            this.btnByOut.Click += new System.EventHandler(this.btnByOut_Click);
            // 
            // btnParams
            // 
            this.btnParams.Location = new System.Drawing.Point(80, 258);
            this.btnParams.Name = "btnParams";
            this.btnParams.Size = new System.Drawing.Size(122, 52);
            this.btnParams.TabIndex = 4;
            this.btnParams.Text = "Params參數";
            this.btnParams.UseVisualStyleBackColor = true;
            this.btnParams.Click += new System.EventHandler(this.btnParams_Click);
            // 
            // Form_M16參數
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnParams);
            this.Controls.Add(this.btnByOut);
            this.Controls.Add(this.btnByref);
            this.Controls.Add(this.btnByReference);
            this.Controls.Add(this.btnByValue);
            this.Name = "Form_M16參數";
            this.Text = "Form_M16參數";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnByValue;
        private System.Windows.Forms.Button btnByReference;
        private System.Windows.Forms.Button btnByref;
        private System.Windows.Forms.Button btnByOut;
        private System.Windows.Forms.Button btnParams;
    }
}