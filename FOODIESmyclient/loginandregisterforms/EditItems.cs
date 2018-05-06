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
    public partial class EditItems : Form
    {
        public EditItems()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];

               comboBox1.Text   = row.Cells[0].Value.ToString();
                textBox1.Text= row.Cells[1].Value.ToString();
                textBox3.Text = row.Cells[2].Value.ToString();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            server.Service1 myitems = new server.Service1();
            myitems.additem(textBox1.Text, comboBox1.Text, textBox3.Text);

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                Int32 inx = item.Index;
                server.Service1 server = new server.Service1();
                server.delete(inx, true);
                show();
            }
        }
        public void show()
        {
            server.Service1 o = new server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = o.getlist();
            dataGridView1.DataSource = bs;
            dataGridView1.Columns["Quantity"].Visible = false;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 o = new Form1();
            this.Hide();
            o.Show();
        }

        private void EditItems_Load(object sender, EventArgs e)
        {
            show();
        }
    }
}
