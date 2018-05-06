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
    public partial class UserLogin : Form
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void UserLogin_Load(object sender, EventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        bool validuser;
        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid;
            bool isvaliduser;
            server.Service1 myuser = new server.Service1();
            myuser.login(textBox1.Text, textBox2.Text, out isvalid, out isvaliduser);
            if (isvalid)
            {
                MessageBox.Show("Valid user");
                validuser = true;
            }
            else
            {
                MessageBox.Show("Invalid user");
                validuser = false;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (validuser == true)
            {
                menu o = new menu();
                this.Hide();
                o.Show();
            }
            else
            {
                MessageBox.Show("Please loGin to Your Account ");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
