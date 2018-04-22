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

            table.Rows.Add(textBox1.Text, comboBox1.Text, textBox2.Text);
            dataGridView1.DataSource = table;


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
            table.Rows.Add(textBox1.Text, comboBox1.Text, textBox2.Text);
            dataGridView1.DataSource = table;

            
        }
    }
}
