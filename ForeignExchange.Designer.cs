namespace Bank
{
    partial class ForeignExchange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForeignExchange));
            this.currencyChoose = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.holdExc = new System.Windows.Forms.TextBox();
            this.excToRmbBtn = new System.Windows.Forms.RadioButton();
            this.rmbToExcBtn = new System.Windows.Forms.RadioButton();
            this.excNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buyPrice = new System.Windows.Forms.Label();
            this.sellPrice = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // currencyChoose
            // 
            this.currencyChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currencyChoose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.currencyChoose.ForeColor = System.Drawing.SystemColors.GrayText;
            this.currencyChoose.FormattingEnabled = true;
            this.currencyChoose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.currencyChoose.Items.AddRange(new object[] {
            "美元",
            "日元",
            "港币"});
            this.currencyChoose.Location = new System.Drawing.Point(109, 36);
            this.currencyChoose.Margin = new System.Windows.Forms.Padding(4);
            this.currencyChoose.Name = "currencyChoose";
            this.currencyChoose.Size = new System.Drawing.Size(103, 32);
            this.currencyChoose.TabIndex = 0;
            this.currencyChoose.SelectedIndexChanged += new System.EventHandler(this.currencyChoose_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(243, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "持有量";
            // 
            // holdExc
            // 
            this.holdExc.Cursor = System.Windows.Forms.Cursors.No;
            this.holdExc.Enabled = false;
            this.holdExc.Location = new System.Drawing.Point(347, 36);
            this.holdExc.Margin = new System.Windows.Forms.Padding(4);
            this.holdExc.Name = "holdExc";
            this.holdExc.ReadOnly = true;
            this.holdExc.Size = new System.Drawing.Size(134, 35);
            this.holdExc.TabIndex = 7;
            this.holdExc.TabStop = false;
            this.holdExc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // excToRmbBtn
            // 
            this.excToRmbBtn.AutoSize = true;
            this.excToRmbBtn.BackColor = System.Drawing.Color.Transparent;
            this.excToRmbBtn.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.excToRmbBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.excToRmbBtn.Location = new System.Drawing.Point(198, 166);
            this.excToRmbBtn.Margin = new System.Windows.Forms.Padding(4);
            this.excToRmbBtn.Name = "excToRmbBtn";
            this.excToRmbBtn.Size = new System.Drawing.Size(104, 35);
            this.excToRmbBtn.TabIndex = 2;
            this.excToRmbBtn.TabStop = true;
            this.excToRmbBtn.Text = "结汇：";
            this.excToRmbBtn.UseVisualStyleBackColor = false;
            this.excToRmbBtn.CheckedChanged += new System.EventHandler(this.excToRmbBtn_CheckedChanged);
            // 
            // rmbToExcBtn
            // 
            this.rmbToExcBtn.AutoSize = true;
            this.rmbToExcBtn.BackColor = System.Drawing.Color.Transparent;
            this.rmbToExcBtn.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.rmbToExcBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rmbToExcBtn.Location = new System.Drawing.Point(198, 100);
            this.rmbToExcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rmbToExcBtn.Name = "rmbToExcBtn";
            this.rmbToExcBtn.Size = new System.Drawing.Size(104, 35);
            this.rmbToExcBtn.TabIndex = 1;
            this.rmbToExcBtn.TabStop = true;
            this.rmbToExcBtn.Text = "购汇：";
            this.rmbToExcBtn.UseVisualStyleBackColor = false;
            this.rmbToExcBtn.CheckedChanged += new System.EventHandler(this.rmbToExcBtn_CheckedChanged);
            // 
            // excNum
            // 
            this.excNum.Location = new System.Drawing.Point(308, 240);
            this.excNum.Margin = new System.Windows.Forms.Padding(4);
            this.excNum.Name = "excNum";
            this.excNum.Size = new System.Drawing.Size(148, 35);
            this.excNum.TabIndex = 3;
            this.excNum.TextChanged += new System.EventHandler(this.excNum_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(118, 239);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "兑换数量";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::Bank.Properties.Resources.图片1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.button1.ForeColor = System.Drawing.Color.Teal;
            this.button1.Location = new System.Drawing.Point(191, 362);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 46);
            this.button1.TabIndex = 4;
            this.button1.Text = "确认兑换";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(304, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "买入价";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(304, 168);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 31);
            this.label4.TabIndex = 10;
            this.label4.Text = "卖出价";
            // 
            // buyPrice
            // 
            this.buyPrice.AutoSize = true;
            this.buyPrice.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.buyPrice.Location = new System.Drawing.Point(402, 102);
            this.buyPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.buyPrice.Name = "buyPrice";
            this.buyPrice.Size = new System.Drawing.Size(21, 31);
            this.buyPrice.TabIndex = 11;
            this.buyPrice.Text = " ";
            // 
            // sellPrice
            // 
            this.sellPrice.AutoSize = true;
            this.sellPrice.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.sellPrice.Location = new System.Drawing.Point(402, 168);
            this.sellPrice.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.sellPrice.Name = "sellPrice";
            this.sellPrice.Size = new System.Drawing.Size(21, 31);
            this.sellPrice.TabIndex = 12;
            this.sellPrice.Text = " ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(46, 133);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "兑换方向";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(94, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 14;
            this.label6.Text = "等额人民币";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.No;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(308, 295);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(148, 35);
            this.textBox1.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(27, 36);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 31);
            this.label7.TabIndex = 16;
            this.label7.Text = "币种";
            // 
            // ForeignExchange
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(522, 431);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sellPrice);
            this.Controls.Add(this.buyPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.excNum);
            this.Controls.Add(this.rmbToExcBtn);
            this.Controls.Add(this.excToRmbBtn);
            this.Controls.Add(this.holdExc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currencyChoose);
            this.Font = new System.Drawing.Font("宋体", 18F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ForeignExchange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " 外汇兑换";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox currencyChoose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox holdExc;
        private System.Windows.Forms.RadioButton excToRmbBtn;
        private System.Windows.Forms.RadioButton rmbToExcBtn;
        private System.Windows.Forms.TextBox excNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label buyPrice;
        private System.Windows.Forms.Label sellPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
    }
}