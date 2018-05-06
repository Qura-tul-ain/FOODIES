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
    public partial class Add_items : Form
    {
        public Add_items()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void Add_items_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Item", typeof(string));
            table.Columns.Add("Category", typeof(string));
            table.Columns.Add("Price", typeof(int));

            dataGridView1.DataSource = table;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            server.Service1 myitems = new server.Service1();
            myitems.additem(textBox1.Text, comboBox1.Text, textBox2.Text);
            show();


           /* table.Rows.Add(textBox1.Text, comboBox1.Text, textBox2.Text);
            dataGridView1.DataSource = table;
            server.Service1 obj = new server.Service1();
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
            dataGridView1.Columns["Quantity"].Visible = false;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //table.Rows.Add(textBox1.Text, comboBox1.Text, textBox2.Text);
            //dataGridView1.DataSource = table;


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Add_deals o = new Add_deals();
            this.Hide();
            o.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                Int32 inx = item.Index;
                server.Service1 server = new server.Service1();
                server.delete(inx, true);
                show();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EditItems o = new EditItems();
            this.Hide();
            o.Show();
        }
    }
}

