﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.Show();
        }
        bool validcall;
        private void button1_Click(object sender, EventArgs e)
        {
            bool isvalid;
            bool isvaliduser;
            server.Service1 myuser = new server.Service1();
            myuser.loginAdmin(textBox1.Text, textBox2.Text, out isvalid, out isvaliduser);
            if (isvalid)
            {
                MessageBox.Show("Admin is Valid ");
                validcall = true;
            }
            else
            {
                MessageBox.Show("Invalid");
                validcall = false;
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget o = new forget();
            this.Hide();
            o.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (validcall == true)
            {
                Add_items o = new Add_items();
                this.Hide();
                o.Show();
            }
            else
            {
                MessageBox.Show("Please Login to Your Account");
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (validcall == true)
            {
                Add_deals o = new Add_deals();
                this.Hide();
                o.Show();
            }
            else
            {
                MessageBox.Show("Please Login to Your Account");
            }


        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Location o = new Add_Location();
            this.Hide();
            o.Show();
        }
    }
}
