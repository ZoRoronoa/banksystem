using Org.BouncyCastle.Math.EC;
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
    public partial class UserCenter : Form
    {
        public static Form user;
        public UserCenter()
        {
            InitializeComponent();
            user = this;
            label1.Text = "你好，" + Login.Getname();
            
        }
        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_CLOSE = 0xF060;

            if (m.Msg == WM_SYSCOMMAND && ((int)m.WParam == SC_CLOSE))
            {
                System.Environment.Exit(0);

                return;
            }
            base.WndProc(ref m);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            //System.Environment.Exit(0);
            //Application.Exit();
            Welcome insert = new Welcome();
            insert.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangePassword insert = new ChangePassword();
            insert.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DebitCard insert = new DebitCard();
            insert.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreditCard insert = new CreditCard();
            insert.Show();
            this.Hide();
        }
    }
}
