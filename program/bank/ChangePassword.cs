using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Math.EC;

namespace Bank
{
    public partial class ChangePassword : Form
    {
        
        public ChangePassword()
        {
            InitializeComponent();
            
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

        private void button1_Click(object sender, EventArgs e)
        {
            string oldpwd = textBox4.Text;
            string newpwd = textBox2.Text;
            string cfpwd = textBox1.Text;
            
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string phonenumber = Login.Getphonenum();
                string sql = "Select * from userinfo where 手机号='" + phonenumber + "'";
                DB.MySqlDataBase mdb = new DB.MySqlDataBase();
                MySqlDataReader rd = mdb.read(sql);
                rd.Read();
                string pwd = rd["密码"].ToString();
                if (!BCrypt.Net.BCrypt.Verify(oldpwd, pwd))
                {
                    MessageBox.Show("旧密码输入错误");
                }
                else if(newpwd == oldpwd)
                {
                    MessageBox.Show("新密码不能和旧密码相同");
                }
                else if(cfpwd != newpwd)
                {
                    MessageBox.Show("两次密码输入不一致");
                }
                else
                {
                    string sql2 = "UPDATE userinfo SET 密码 = '" + BCrypt.Net.BCrypt.HashPassword(newpwd) + "' where 手机号='" + phonenumber + "'";
                    DB.MySqlDataBase db = new DB.MySqlDataBase();
                    int ext = db.Excute(sql2);
                    if(ext > 0)
                    {
                        MessageBox.Show("修改成功！");
                        Login insert = new Login();
                        insert.Show();
                        this.Close();
                        
                        
                    }
                }
            }

        }
    }
}
