namespace Work_MyPOS
{
    partial class FormMyPOS
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
            this.labMenu = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.labPay = new System.Windows.Forms.Label();
            this.labList = new System.Windows.Forms.Label();
            this.btnBeer = new System.Windows.Forms.Button();
            this.btnTeq = new System.Windows.Forms.Button();
            this.btnWine = new System.Windows.Forms.Button();
            this.btnWhisky = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnCard = new System.Windows.Forms.Button();
            this.txtList = new System.Windows.Forms.TextBox();
            this.btnList = new System.Windows.Forms.Button();
            this.labDiscount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labMenu
            // 
            this.labMenu.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labMenu.Location = new System.Drawing.Point(7, 29);
            this.labMenu.Name = "labMenu";
            this.labMenu.Size = new System.Drawing.Size(220, 260);
            this.labMenu.TabIndex = 0;
            this.labMenu.Text = "菜單";
            this.labMenu.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labTotal
            // 
            this.labTotal.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labTotal.Location = new System.Drawing.Point(247, 29);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(248, 99);
            this.labTotal.TabIndex = 1;
            this.labTotal.Text = "總金額";
            this.labTotal.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labPay
            // 
            this.labPay.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labPay.Location = new System.Drawing.Point(247, 243);
            this.labPay.Name = "labPay";
            this.labPay.Size = new System.Drawing.Size(245, 31);
            this.labPay.TabIndex = 2;
            this.labPay.Text = "付款方式";
            this.labPay.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labList
            // 
            this.labList.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labList.Location = new System.Drawing.Point(568, 29);
            this.labList.Name = "labList";
            this.labList.Size = new System.Drawing.Size(220, 260);
            this.labList.TabIndex = 3;
            this.labList.Text = "清單";
            this.labList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBeer
            // 
            this.btnBeer.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBeer.Location = new System.Drawing.Point(12, 82);
            this.btnBeer.Name = "btnBeer";
            this.btnBeer.Size = new System.Drawing.Size(100, 66);
            this.btnBeer.TabIndex = 4;
            this.btnBeer.Text = "啤酒NT$120";
            this.btnBeer.UseVisualStyleBackColor = true;
            this.btnBeer.Click += new System.EventHandler(this.btnBeer_Click);
            // 
            // btnTeq
            // 
            this.btnTeq.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTeq.Location = new System.Drawing.Point(118, 82);
            this.btnTeq.Name = "btnTeq";
            this.btnTeq.Size = new System.Drawing.Size(100, 66);
            this.btnTeq.TabIndex = 5;
            this.btnTeq.Text = "龍舌蘭NT$180";
            this.btnTeq.UseVisualStyleBackColor = true;
            this.btnTeq.Click += new System.EventHandler(this.btnTeq_Click);
            // 
            // btnWine
            // 
            this.btnWine.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWine.Location = new System.Drawing.Point(118, 178);
            this.btnWine.Name = "btnWine";
            this.btnWine.Size = new System.Drawing.Size(100, 66);
            this.btnWine.TabIndex = 6;
            this.btnWine.Text = "紅酒NT$320";
            this.btnWine.UseVisualStyleBackColor = true;
            this.btnWine.Click += new System.EventHandler(this.btnWine_Click);
            // 
            // btnWhisky
            // 
            this.btnWhisky.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnWhisky.Location = new System.Drawing.Point(12, 178);
            this.btnWhisky.Name = "btnWhisky";
            this.btnWhisky.Size = new System.Drawing.Size(100, 66);
            this.btnWhisky.TabIndex = 7;
            this.btnWhisky.Text = "威士忌NT$350";
            this.btnWhisky.UseVisualStyleBackColor = true;
            this.btnWhisky.Click += new System.EventHandler(this.btnWhisky_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotal.Location = new System.Drawing.Point(320, 82);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 29);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnMoney
            // 
            this.btnMoney.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMoney.Location = new System.Drawing.Point(252, 287);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(100, 66);
            this.btnMoney.TabIndex = 9;
            this.btnMoney.Text = "現金";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnCard
            // 
            this.btnCard.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCard.Location = new System.Drawing.Point(392, 287);
            this.btnCard.Name = "btnCard";
            this.btnCard.Size = new System.Drawing.Size(100, 66);
            this.btnCard.TabIndex = 10;
            this.btnCard.Text = "信用卡";
            this.btnCard.UseVisualStyleBackColor = true;
            this.btnCard.Click += new System.EventHandler(this.btnCard_Click);
            // 
            // txtList
            // 
            this.txtList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtList.Location = new System.Drawing.Point(518, 68);
            this.txtList.Multiline = true;
            this.txtList.Name = "txtList";
            this.txtList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtList.Size = new System.Drawing.Size(270, 234);
            this.txtList.TabIndex = 11;
            this.txtList.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnList
            // 
            this.btnList.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnList.Location = new System.Drawing.Point(664, 330);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(100, 40);
            this.btnList.TabIndex = 12;
            this.btnList.Text = "清除清單";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // labDiscount
            // 
            this.labDiscount.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.labDiscount.Location = new System.Drawing.Point(360, 376);
            this.labDiscount.Name = "labDiscount";
            this.labDiscount.Size = new System.Drawing.Size(167, 31);
            this.labDiscount.TabIndex = 13;
            this.labDiscount.Text = "信用卡打九折";
            this.labDiscount.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMyPOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labDiscount);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtList);
            this.Controls.Add(this.btnCard);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnWhisky);
            this.Controls.Add(this.btnWine);
            this.Controls.Add(this.btnTeq);
            this.Controls.Add(this.btnBeer);
            this.Controls.Add(this.labList);
            this.Controls.Add(this.labPay);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.labMenu);
            this.Name = "FormMyPOS";
            this.Text = "MyPOS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labMenu;
        private System.Windows.Forms.Label labTotal;
        private System.Windows.Forms.Label labPay;
        private System.Windows.Forms.Label labList;
        private System.Windows.Forms.Button btnBeer;
        private System.Windows.Forms.Button btnTeq;
        private System.Windows.Forms.Button btnWine;
        private System.Windows.Forms.Button btnWhisky;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnCard;
        private System.Windows.Forms.TextBox txtList;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label labDiscount;
    }
}

