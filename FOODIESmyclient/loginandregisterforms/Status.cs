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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void Status_Load(object sender, EventArgs e)
        {
            show();
        }
        public void show()
        {
            server.Service1 o = new server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = o.getuser();
            dataGridView1.DataSource = bs;
            dataGridView1.Columns["Isadmin"].Visible = false;
            dataGridView1.Columns["Password"].Visible = false;
            dataGridView1.Columns["Cpassword"].Visible = false;
            dataGridView1.Columns["Iscashier"].Visible = false;
            dataGridView1.Columns["IsadminSpecified"].Visible = false;
            dataGridView1.Columns["IscashierSpecified"].Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Boolean a=true;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                a=Convert.ToBoolean(row.Cells[0].Value);
                
                    if (a)
                    {
                        MessageBox.Show("vghh");
                    }
                
                else
                {
                    MessageBox.Show("Order is completed");
                }
            }
        }
    }
}
