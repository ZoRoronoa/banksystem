using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Bank
{
    public partial class CreditCard : Form
    {
        string phonenumber = Login.Getphonenum();       //获取本次登录账户的手机号
        public CreditCard()
        {
            InitializeComponent();
            label6.Text = "你好，" + Login.Getname();
            UsableCrdTBox.Text = getUsable().ToString();
            UsedCrdTBox.Text = getUsed().ToString();

            

        }

        public double usedCrd;
        public double usableCrd;
        public double defaultCrd = 3000;

        public double draw;
        public double pay;

        public double getUsed()
        {
            //………… get "已用额度" from DB
            string sql1 = "Select * from creditcardinfo where 手机号='" + phonenumber + "'";
            DB.MySqlDataBase mdb = new DB.MySqlDataBase();
            MySqlDataReader rd = mdb.read(sql1);
            rd.Read();
            string a = rd["已用额度"].ToString();
            rd.Close();
            usedCrd = Convert.ToDouble(a);

            

            return usedCrd; 
        }

        public double getUsable()
        {
            //………… get "可用额度" from DB
            string sql2 = "Select * from creditcardinfo where 手机号='" + phonenumber + "'";
            DB.MySqlDataBase db = new DB.MySqlDataBase();
            MySqlDataReader dr = db.read(sql2);
            dr.Read();
            string b = dr["可用额度"].ToString();
            dr.Close();
            usableCrd = Convert.ToDouble(b);

            return usableCrd;   
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_CLOSE))
            {
                UserCenter.user.Show();
                this.Close();

                return;
            }
            base.WndProc(ref m);
        }

        private void UsableCrd_TextChanged(object sender, EventArgs e)
        {
            //UsableCrdTBox.Text = getUsable().ToString();
        }

        private void UsedCrd_TextChanged(object sender, EventArgs e)
        {
            //UsedCrdTBox.Text = getUsed().ToString();
        }

        double Balance;
        public double getBalance()
        {
            string sql1 = "Select * from debitcardinfo where 手机号='" + phonenumber + "'";
            DB.MySqlDataBase mdb = new DB.MySqlDataBase();
            MySqlDataReader rd = mdb.read(sql1);
            rd.Read();
            string a = rd["活期存款余额"].ToString();
            rd.Close();
            Balance = double.Parse(a);

            return Balance;
        }


        private void PayBtn_Click(object sender, EventArgs e)
        {
            //double pay = System.Convert.ToDouble(PayTBox.Text);
            try
            {
                double pay = System.Convert.ToDouble(PayTBox.Text);

                if(pay > getBalance())
                {
                    MessageBox.Show("储蓄卡余额不足");
                }

                else if(pay <= 0)
                {
                    MessageBox.Show("还款金额应大于0！");
                    PayTBox.Text = "";
                }

                else
                {
                    if (pay <= getUsed())
                    {
                        UsedCrdTBox.Text = (getUsed() - pay).ToString();   // Update "已用额度" text
                        UsableCrdTBox.Text = (getUsable() + pay).ToString();   // Update "可用额度" text
                                                                               //Update DB

                        double newBalance = getBalance() - pay;                //使用储蓄卡还款信用卡后，储蓄卡的余额

                        string sql3 = "UPDATE creditcardinfo SET 已用额度 = '" + UsedCrdTBox.Text + "', 可用额度 = '" + UsableCrdTBox.Text + "' where 手机号='" + phonenumber + "'";
                        string sql4 = "UPDATE debitcardinfo SET 活期存款余额 = '" + newBalance + "' where 手机号='" + phonenumber + "'";
                        DB.MySqlDataBase db3 = new DB.MySqlDataBase();
                        int ext3 = db3.Excute(sql3);
                        int ext4 = db3.Excute(sql4);
                        if (ext3 > 0)
                        {
                            MessageBox.Show("还款成功！");
                            //CreditCard insert = new CreditCard();
                            //this.Close();
                            DrawTbox.Text = "";
                            PayTBox.Text = "";
                        }
                    }
                    else MessageBox.Show("超出需还额度！");
                }

                
            }
            catch
            {
                MessageBox.Show("还款金额不能为空！");
            }
            
        }

        private void DrawBtn_Click(object sender, EventArgs e)
        {
            try
            {
                double draw = System.Convert.ToDouble(DrawTbox.Text);

                if(draw <= 0)
                {
                    MessageBox.Show("支取金额应大于0！");
                    DrawTbox.Text = "";
                }

                else if (draw <= getUsable())
                {
                    UsedCrdTBox.Text = (getUsed() + draw).ToString();   // Update "已用额度" text
                    UsableCrdTBox.Text = (getUsable() - draw).ToString();   // Update "可用额度" text
                                                                            //Update DB
                    string sql4 = "UPDATE creditcardinfo SET 已用额度 = '" + UsedCrdTBox.Text + "', 可用额度 = '" + UsableCrdTBox.Text + "' where 手机号='" + phonenumber + "'";
                    DB.MySqlDataBase db4 = new DB.MySqlDataBase();
                    int ext4 = db4.Excute(sql4);
                    if (ext4 > 0)
                    {
                        MessageBox.Show("支取成功！");
                        //CreditCard insert = new CreditCard();
                        //this.Close();
                        DrawTbox.Text = "";
                        PayTBox.Text = "";
                    }

                }
                else MessageBox.Show("超出可用额度！");
            }
            catch
            {
                MessageBox.Show("支取金额不能为空！");
            }
            
        }
    }
}
