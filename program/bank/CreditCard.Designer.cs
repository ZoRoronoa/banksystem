namespace Bank
{
    partial class CreditCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditCard));
            this.UsableCrdTBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsedCrdTBox = new System.Windows.Forms.TextBox();
            this.DefaultCrdTBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DrawTbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.PayBtn = new System.Windows.Forms.Button();
            this.DrawBtn = new System.Windows.Forms.Button();
            this.PayTBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UsableCrdTBox
            // 
            this.UsableCrdTBox.Cursor = System.Windows.Forms.Cursors.No;
            this.UsableCrdTBox.Enabled = false;
            this.UsableCrdTBox.Location = new System.Drawing.Point(257, 238);
            this.UsableCrdTBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsableCrdTBox.Name = "UsableCrdTBox";
            this.UsableCrdTBox.ReadOnly = true;
            this.UsableCrdTBox.Size = new System.Drawing.Size(148, 35);
            this.UsableCrdTBox.TabIndex = 19;
            this.UsableCrdTBox.TabStop = false;
            this.UsableCrdTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsableCrdTBox.TextChanged += new System.EventHandler(this.UsableCrd_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label4.Location = new System.Drawing.Point(98, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 18;
            this.label4.Text = "已用额度：";
            // 
            // UsedCrdTBox
            // 
            this.UsedCrdTBox.Cursor = System.Windows.Forms.Cursors.No;
            this.UsedCrdTBox.Enabled = false;
            this.UsedCrdTBox.Location = new System.Drawing.Point(257, 180);
            this.UsedCrdTBox.Margin = new System.Windows.Forms.Padding(4);
            this.UsedCrdTBox.Name = "UsedCrdTBox";
            this.UsedCrdTBox.ReadOnly = true;
            this.UsedCrdTBox.Size = new System.Drawing.Size(148, 35);
            this.UsedCrdTBox.TabIndex = 17;
            this.UsedCrdTBox.TabStop = false;
            this.UsedCrdTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.UsedCrdTBox.TextChanged += new System.EventHandler(this.UsedCrd_TextChanged);
            // 
            // DefaultCrdTBox
            // 
            this.DefaultCrdTBox.Cursor = System.Windows.Forms.Cursors.No;
            this.DefaultCrdTBox.Enabled = false;
            this.DefaultCrdTBox.Location = new System.Drawing.Point(257, 122);
            this.DefaultCrdTBox.Margin = new System.Windows.Forms.Padding(4);
            this.DefaultCrdTBox.Name = "DefaultCrdTBox";
            this.DefaultCrdTBox.ReadOnly = true;
            this.DefaultCrdTBox.Size = new System.Drawing.Size(148, 35);
            this.DefaultCrdTBox.TabIndex = 16;
            this.DefaultCrdTBox.TabStop = false;
            this.DefaultCrdTBox.Text = "3000";
            this.DefaultCrdTBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label5.Location = new System.Drawing.Point(98, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 15;
            this.label5.Text = "可用额度：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label1.Location = new System.Drawing.Point(50, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 14;
            this.label1.Text = "你的信用额度：";
            // 
            // DrawTbox
            // 
            this.DrawTbox.Location = new System.Drawing.Point(257, 324);
            this.DrawTbox.Margin = new System.Windows.Forms.Padding(4);
            this.DrawTbox.Name = "DrawTbox";
            this.DrawTbox.Size = new System.Drawing.Size(148, 35);
            this.DrawTbox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(98, 324);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 31);
            this.label2.TabIndex = 20;
            this.label2.Text = "刷卡消费：";
            // 
            // PayBtn
            // 
            this.PayBtn.BackColor = System.Drawing.Color.Transparent;
            this.PayBtn.BackgroundImage = global::Bank.Properties.Resources.图片1;
            this.PayBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PayBtn.FlatAppearance.BorderSize = 0;
            this.PayBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PayBtn.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.PayBtn.ForeColor = System.Drawing.Color.Teal;
            this.PayBtn.Location = new System.Drawing.Point(453, 381);
            this.PayBtn.Margin = new System.Windows.Forms.Padding(4);
            this.PayBtn.Name = "PayBtn";
            this.PayBtn.Size = new System.Drawing.Size(138, 42);
            this.PayBtn.TabIndex = 3;
            this.PayBtn.Text = "确认还款";
            this.PayBtn.UseVisualStyleBackColor = false;
            this.PayBtn.Click += new System.EventHandler(this.PayBtn_Click);
            // 
            // DrawBtn
            // 
            this.DrawBtn.BackColor = System.Drawing.Color.Transparent;
            this.DrawBtn.BackgroundImage = global::Bank.Properties.Resources.图片1;
            this.DrawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DrawBtn.FlatAppearance.BorderSize = 0;
            this.DrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DrawBtn.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.DrawBtn.ForeColor = System.Drawing.Color.Teal;
            this.DrawBtn.Location = new System.Drawing.Point(453, 322);
            this.DrawBtn.Margin = new System.Windows.Forms.Padding(4);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(138, 42);
            this.DrawBtn.TabIndex = 1;
            this.DrawBtn.Text = "确认支取";
            this.DrawBtn.UseVisualStyleBackColor = false;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // PayTBox
            // 
            this.PayTBox.Location = new System.Drawing.Point(257, 382);
            this.PayTBox.Margin = new System.Windows.Forms.Padding(4);
            this.PayTBox.Name = "PayTBox";
            this.PayTBox.Size = new System.Drawing.Size(148, 35);
            this.PayTBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 18F);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(50, 382);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 31);
            this.label3.TabIndex = 23;
            this.label3.Text = "从储蓄卡还款：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("楷体", 25F);
            this.label6.Location = new System.Drawing.Point(45, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(219, 34);
            this.label6.TabIndex = 26;
            this.label6.Text = "你好，$姓名$";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(640, 446);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DrawBtn);
            this.Controls.Add(this.PayTBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PayBtn);
            this.Controls.Add(this.DrawTbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UsableCrdTBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.UsedCrdTBox);
            this.Controls.Add(this.DefaultCrdTBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 18F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "信用卡";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsableCrdTBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UsedCrdTBox;
        private System.Windows.Forms.TextBox DefaultCrdTBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DrawTbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PayBtn;
        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.TextBox PayTBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}