namespace Work_Calculator
{
    partial class Work_Loan
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
            this.labLoanAmount = new System.Windows.Forms.Label();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.txtTerm = new System.Windows.Forms.TextBox();
            this.labTerm = new System.Windows.Forms.Label();
            this.txtRates = new System.Windows.Forms.TextBox();
            this.labRates = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.labDownPayment = new System.Windows.Forms.Label();
            this.btnMonthly = new System.Windows.Forms.Button();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labLoanAmount
            // 
            this.labLoanAmount.AutoSize = true;
            this.labLoanAmount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labLoanAmount.Location = new System.Drawing.Point(63, 46);
            this.labLoanAmount.Name = "labLoanAmount";
            this.labLoanAmount.Size = new System.Drawing.Size(101, 27);
            this.labLoanAmount.TabIndex = 0;
            this.labLoanAmount.Text = "貸款金額:";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLoanAmount.Location = new System.Drawing.Point(185, 43);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(128, 35);
            this.txtLoanAmount.TabIndex = 1;
            this.txtLoanAmount.Text = "100000";
            // 
            // txtTerm
            // 
            this.txtTerm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTerm.Location = new System.Drawing.Point(185, 109);
            this.txtTerm.Name = "txtTerm";
            this.txtTerm.Size = new System.Drawing.Size(128, 35);
            this.txtTerm.TabIndex = 3;
            this.txtTerm.Text = "2";
            // 
            // labTerm
            // 
            this.labTerm.AutoSize = true;
            this.labTerm.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTerm.Location = new System.Drawing.Point(63, 112);
            this.labTerm.Name = "labTerm";
            this.labTerm.Size = new System.Drawing.Size(94, 27);
            this.labTerm.TabIndex = 2;
            this.labTerm.Text = "期限(年):";
            // 
            // txtRates
            // 
            this.txtRates.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRates.Location = new System.Drawing.Point(185, 172);
            this.txtRates.Name = "txtRates";
            this.txtRates.Size = new System.Drawing.Size(128, 35);
            this.txtRates.TabIndex = 5;
            this.txtRates.Text = "6";
            // 
            // labRates
            // 
            this.labRates.AutoSize = true;
            this.labRates.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labRates.Location = new System.Drawing.Point(63, 175);
            this.labRates.Name = "labRates";
            this.labRates.Size = new System.Drawing.Size(91, 27);
            this.labRates.TabIndex = 4;
            this.labRates.Text = "利率(%):";
            // 
            // txtDownPayment
            // 
            this.txtDownPayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDownPayment.Location = new System.Drawing.Point(185, 236);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(128, 35);
            this.txtDownPayment.TabIndex = 7;
            this.txtDownPayment.Text = "0";
            // 
            // labDownPayment
            // 
            this.labDownPayment.AutoSize = true;
            this.labDownPayment.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDownPayment.Location = new System.Drawing.Point(63, 239);
            this.labDownPayment.Name = "labDownPayment";
            this.labDownPayment.Size = new System.Drawing.Size(80, 27);
            this.labDownPayment.TabIndex = 6;
            this.labDownPayment.Text = "頭期款:";
            // 
            // btnMonthly
            // 
            this.btnMonthly.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMonthly.Location = new System.Drawing.Point(104, 329);
            this.btnMonthly.Name = "btnMonthly";
            this.btnMonthly.Size = new System.Drawing.Size(140, 44);
            this.btnMonthly.TabIndex = 8;
            this.btnMonthly.Text = "月付款";
            this.btnMonthly.UseVisualStyleBackColor = true;
            this.btnMonthly.Click += new System.EventHandler(this.btnMonthly_Click);
            // 
            // btnTotal
            // 
            this.btnTotal.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTotal.Location = new System.Drawing.Point(297, 329);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(140, 44);
            this.btnTotal.TabIndex = 9;
            this.btnTotal.Text = "總付款";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnReport
            // 
            this.btnReport.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReport.Location = new System.Drawing.Point(486, 329);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(140, 44);
            this.btnReport.TabIndex = 10;
            this.btnReport.Text = "Report";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // Work_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReport);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.btnMonthly);
            this.Controls.Add(this.txtDownPayment);
            this.Controls.Add(this.labDownPayment);
            this.Controls.Add(this.txtRates);
            this.Controls.Add(this.labRates);
            this.Controls.Add(this.txtTerm);
            this.Controls.Add(this.labTerm);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.labLoanAmount);
            this.Name = "Work_Loan";
            this.Text = "Work_Loan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labLoanAmount;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.TextBox txtTerm;
        private System.Windows.Forms.Label labTerm;
        private System.Windows.Forms.TextBox txtRates;
        private System.Windows.Forms.Label labRates;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.Label labDownPayment;
        private System.Windows.Forms.Button btnMonthly;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnReport;
    }
}