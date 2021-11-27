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
    
    public partial class DebitCard : Form
    {
        public static Form debit;

        string phonenumber = Login.Getphonenum();       //获取本次登录账户的手机号
        public DebitCard()
        {
            InitializeComponent();
            debit = this;
            label1.Text = "你好，" + Login.Getname();
            textBox1.Text = getBalance().ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            TimeDeposit insert = new TimeDeposit();
            insert.Show();
            this.Hide();
        }



        private void button5_Click(object sender, EventArgs e)
        {

            

            ForeignExchange foreignExchange = new ForeignExchange();
            foreignExchange.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            try
            {
                double withdrawacc = System.Convert.ToDouble(textBox3.Text);
                if(withdrawacc <= 0)
                {
                    MessageBox.Show("取款金额应大于0！");
                    textBox3.Text = "";
                }
                else if(withdrawacc > getBalance())
                {
                    MessageBox.Show("储蓄卡余额不足！");
                }
                else
                {
                    double newBalance = getBalance() - withdrawacc;
                    //Update Balance to DB
                    //把新的余额的值写入数据库

                    string sql3 = "UPDATE debitcardinfo SET 活期存款余额 = '" + newBalance + "' where 手机号='" + phonenumber + "'";
                    DB.MySqlDataBase db3 = new DB.MySqlDataBase();
                    int ext3 = db3.Excute(sql3);
                    if (ext3 > 0)
                    {
                        MessageBox.Show("取款成功！");
                        textBox3.Text = "";
                        textBox1.Text = getBalance().ToString();

                    }
                }
                

            }
            catch
            {
                MessageBox.Show("请输入取款金额");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double depositacc = System.Convert.ToDouble(textBox2.Text);
                if(depositacc <= 0)
                {
                    MessageBox.Show("存款金额应大于0！");
                    textBox2.Text = "";
                }
                else
                {
                    double newBalance = getBalance() + depositacc;
                    //Update Balance to DB
                    //把新的余额的值写入数据库

                    string sql3 = "UPDATE debitcardinfo SET 活期存款余额 = '" + newBalance + "' where 手机号='" + phonenumber + "'";
                    DB.MySqlDataBase db3 = new DB.MySqlDataBase();
                    int ext3 = db3.Excute(sql3);
                    if (ext3 > 0)
                    {
                        MessageBox.Show("存款成功！");
                        textBox2.Text = "";
                        textBox1.Text = getBalance().ToString();

                    }
                }
                

            }
            catch
            {
                MessageBox.Show("请输入存款金额");
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Text = getBalance().ToString();
        }
    }
}
