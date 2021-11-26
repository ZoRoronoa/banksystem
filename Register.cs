using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_CLOSE))
            {
                Welcome.wel.Show();
                this.Close();

                return;
            }
            base.WndProc(ref m);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string name = textBox1.Text.Trim();
                string phonenumber = textBox4.Text.Trim();
                string password = textBox2.Text;
                string cfpwd = textBox3.Text;
                string sql = "INSERT INTO userinfo VALUES('" + name + "','" + phonenumber + "','" + BCrypt.Net.BCrypt.HashPassword(password) + "')";
                string sql2 = "INSERT INTO creditcardinfo VALUES('" + phonenumber + "','3000','0', '3000')";
                string sql3 = "INSERT INTO debitcardinfo VALUES('" + phonenumber + "', '0')";
                string sql4 = "INSERT INTO foreignexchange VALUES('" + phonenumber + "','美元','0')";
                string sql5 = "INSERT INTO foreignexchange VALUES('" + phonenumber + "','日元','0')";
                string sql6 = "INSERT INTO foreignexchange VALUES('" + phonenumber + "','港币','0')";
                if (cfpwd == password)
                {
                    
                    try
                    {
                        DB.MySqlDataBase mdb = new DB.MySqlDataBase();
                        int ext = mdb.Excute(sql);
                        int ext2 = mdb.Excute(sql2);
                        int ext3 = mdb.Excute(sql3);
                        int ext4 = mdb.Excute(sql4);
                        int ext5 = mdb.Excute(sql5);
                        int ext6 = mdb.Excute(sql6);
                        if (ext > 0)
                        {
                            MessageBox.Show("注册成功！");
                            Welcome insert = new Welcome();
                            insert.Show();
                            //this.Hide();
                            this.Close();
                        }
                    }
                   
                    catch
                    {
                        MessageBox.Show("该手机号已被注册");
                    }
                    
                }
                else
                {
                    MessageBox.Show("两次密码输入不一致", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }
    }
}
