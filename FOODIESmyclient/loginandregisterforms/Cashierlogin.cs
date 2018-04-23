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
    public partial class Cashierlogin : Form
    {
        public Cashierlogin()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid;
            bool isvaliduser;
            server.Service1 myuser = new server.Service1();
            myuser.login(textBox1.Text, textBox2.Text, out isvalid, out isvaliduser);
            if (isvalid)
            {
                MessageBox.Show("Valid user");
            }
            else
            {
                MessageBox.Show("Invalid user");
            }
        }
    }
}
