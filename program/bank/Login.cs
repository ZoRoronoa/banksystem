using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace Bank
{
    public partial class Login : Form
    {
        public static Login f1;
        public Login()
        {
            InitializeComponent();
            f1 = this;
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
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("输入不完整，请检查", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string phonenumber = textBox1.Text.Trim();
                string password = textBox2.Text;
                DB.MySqlDataBase mdb = new DB.MySqlDataBase();              //实例化MySqlDataBase的一个对象mdb
                string sql = "Select * from userinfo where 手机号='" + phonenumber + "'";
                MySqlDataReader rd = mdb.read(sql);

                if (rd.Read())
                {
                    var savedpasswd = rd["密码"].ToString();
                    if (BCrypt.Net.BCrypt.Verify( password, savedpasswd)) {
                        MessageBox.Show("登录成功！");
                        UserCenter insert = new UserCenter();
                        insert.Show();          //显示这个窗体
                        this.Hide();            //隐藏这个窗体

                        //更新BCrypt加密
                        string sql1 = "UPDATE `userinfo` SET `密码` = '" + BCrypt.Net.BCrypt.HashPassword(password) + "' WHERE `手机号` = '" + phonenumber + "'";
                        mdb.read(sql1);

                        rd.Close();

                    }
                    else
                    {
                        MessageBox.Show("密码错误");
                        rd.Close();
                    };
                }
                else
                {
                    MessageBox.Show("手机号不存在");
                    rd.Close();
                }
            }
            
        }
        public static string Getphonenum()
        {
           
            return f1.textBox1.Text.Trim();
        }
        public static string Getname()
        {
            string phonenumber = Getphonenum();
            string sql = "Select * from userinfo where 手机号='" + phonenumber + "'";
            DB.MySqlDataBase mdb = new DB.MySqlDataBase();
            MySqlDataReader rd = mdb.read(sql);
            if(rd.Read())
            {
                string name = rd["姓名"].ToString();
                rd.Close();                             //关闭连接
                return name;
            }
            else
            {
                return "亲爱的用户";
            }
        }
    }
}
