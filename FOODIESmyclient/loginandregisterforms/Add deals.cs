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
            server.Service1 obj = new server.Service1();
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            server.Service1 obj = new server.Service1();
            foreach(items u in ItemDL)
            {

        }
    }
}
