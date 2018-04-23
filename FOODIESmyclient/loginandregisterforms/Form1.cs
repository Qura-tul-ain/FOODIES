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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isCashierSepecified = true;
            bool isAdminSepecified = true;
            bool ispresent;
            bool isregister;
            server.Service1 myservse = new server.Service1();
            myservse.Registeration(textBox1.Text, textBox2.Text, textBox3.Text, checkBox1.Checked, true,checkBox2.Checked,true,out ispresent,out isregister);
            if (ispresent)
            {
                MessageBox.Show("Either User Is already present or password and cpassword is not same!!");
            }
            else
            {
                if(checkBox1.Checked==true)
                {
                    MessageBox.Show("You successfully registered!!! Admin login from Admin login form");
                }
                else if(checkBox2.Checked==true)
                {
                    MessageBox.Show("You successfully registered!!!! Cashier login from Cashier login form");
                }
                else
                {
                    MessageBox.Show("You successfully registered!!!!!! And login from user login form...");
                }
            }
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Cashierlogin o = new Cashierlogin();
            this.Hide();
            o.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            

        }
    }
}
