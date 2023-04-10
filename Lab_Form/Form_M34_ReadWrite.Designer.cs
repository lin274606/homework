namespace Lab_Form
{
    partial class Form_M34_ReadWrite
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
            this.btnReader = new System.Windows.Forms.Button();
            this.txtShow = new System.Windows.Forms.TextBox();
            this.bntStreamWriter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReader
            // 
            this.btnReader.Location = new System.Drawing.Point(40, 41);
            this.btnReader.Name = "btnReader";
            this.btnReader.Size = new System.Drawing.Size(106, 41);
            this.btnReader.TabIndex = 0;
            this.btnReader.Text = "Reader";
            this.btnReader.UseVisualStyleBackColor = true;
            this.btnReader.Click += new System.EventHandler(this.btnReader_Click);
            // 
            // txtShow
            // 
            this.txtShow.Location = new System.Drawing.Point(338, 49);
            this.txtShow.Multiline = true;
            this.txtShow.Name = "txtShow";
            this.txtShow.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtShow.Size = new System.Drawing.Size(427, 357);
            this.txtShow.TabIndex = 1;
            // 
            // bntStreamWriter
            // 
            this.bntStreamWriter.Location = new System.Drawing.Point(40, 116);
            this.bntStreamWriter.Name = "bntStreamWriter";
            this.bntStreamWriter.Size = new System.Drawing.Size(106, 41);
            this.bntStreamWriter.TabIndex = 2;
            this.bntStreamWriter.Text = "Writer";
            this.bntStreamWriter.UseVisualStyleBackColor = true;
            this.bntStreamWriter.Click += new System.EventHandler(this.bntStreamWriter_Click);
            // 
            // Form_M34_ReadWrite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bntStreamWriter);
            this.Controls.Add(this.txtShow);
            this.Controls.Add(this.btnReader);
            this.Name = "Form_M34_ReadWrite";
            this.Text = "Form_M34_ReadWrite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReader;
        private System.Windows.Forms.TextBox txtShow;
        private System.Windows.Forms.Button bntStreamWriter;
    }
}