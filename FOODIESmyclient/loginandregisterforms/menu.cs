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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            server.Service1 s = new server.Service1();
            dataGridView1.AutoGenerateColumns = false;
            string a, b, c, d;
            a = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            b = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            c = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            d = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
            s.orderitem(c, b, d, a);
        }

        public void show()
        {
            server.Service1 o = new server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = o.getlist();
            dataGridView1.DataSource = bs;

        }

        public void showorder()
        {
            server.Service1 oo = new server.Service1();
            BindingSource data = new BindingSource();
            data.DataSource = oo.getorder();
            dataGridView2.DataSource = data;

        }

        private void menu_Load(object sender, EventArgs e)
        {
            show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*foreach(DataGridViewRow item in dataGridView1.Rows)
            {
                if ((bool)item.Cells[0].Value == true)
                {
                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value == item.Cells[1].Value.ToString();
                }
        }*/
            showorder();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pyment o = new pyment();
            this.Hide();
            o.Show();
        }
    }
}
