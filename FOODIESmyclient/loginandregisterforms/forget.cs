using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace loginandregisterforms
{
    public partial class forget : Form
    {
        public forget()
        {
            InitializeComponent();
        }

        private void forget_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UserLogin o = new UserLogin();
            this.Hide();
            o.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login o = new Login();
            this.Hide();
            o.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cashierlogin o = new Cashierlogin();
            this.Hide();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool ischeck;
            bool ischange;
            server.Service1 myuser = new server.Service1();
            myuser.resetpassword(textBox1.Text, out ischange, out ischeck);
            if (ischange)
            {
                MessageBox.Show("Password has been changed");
            }
            else
            {
                MessageBox.Show("Wrong User Name");
            }

        }
    }
}
