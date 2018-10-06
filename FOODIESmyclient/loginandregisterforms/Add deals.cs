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
    public partial class Add_deals : Form
    {
        public Add_deals()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();
        private void Add_deals_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(int));

            dataGridView1.DataSource = table;
            show();
       

        /*server.Service1 obj = new server.Service1();
            List<server.Item> list = obj.getlist().ToList<server.Item>();
            foreach (server.Item u in list)
            {
                BindingSource s = new BindingSource();
                s.DataSource = u;
                dataGridView1.DataSource = s;


            }*/
        }
        public void show()
        {
            server.Service1 o = new server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = o.getlist();
            dataGridView1.DataSource = bs;
            
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            server.Service1 obj = new server.Service1();
            List<server.Item> list = obj.getlist().ToList<server.Item>();
            foreach (server.Item u in list)
            {
                BindingSource s = new BindingSource();
                s.DataSource = u;
                dataGridView1.DataSource = s;


            }
            dataGridView1.Columns["Quantity"].Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_items o = new Add_items();
            this.Hide();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            


            }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            server.Service1 mydeals = new server.Service1();
            mydeals.adddeal(textBox1.Text, textBox2.Text);
            dealshow();
            

        }

        public void dealshow()
        {
            server.Service1 o = new server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = o.getdeal();
            dataGridView2.DataSource = bs;
            dataGridView2.Columns["Quantity"].Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_Location a = new Add_Location();
            this.Hide();
            a.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                Int32 inx = item.Index;
                server.Service1 server = new server.Service1();
                server.deletedeal(inx, true);
                dealshow();
            }
        }
    }
    }// bb dnf nduhjhdb heduheb

