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
    public partial class see_deals : Form
    {
        public see_deals()
        {
            InitializeComponent();
        }

        private void see_deals_Load(object sender, EventArgs e)
        {
            showdeals();
        }
        public void showdeals()
        {
            server.Service1 o = new server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = o.getdeal();
            dataGridView1.DataSource = bs;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*server.Service1 s = new server.Service1();
            dataGridView1.AutoGenerateColumns = false;
            string n, p, q;
            n = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            p = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            q = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            s.orderdeal(n, p, q);*/
        }
        public void showorderdeal()
        {
            server.Service1 s = new server.Service1();
            BindingSource bs = new BindingSource();
            bs.DataSource = s.getorderlist();
            dataGridView2.DataSource = bs;
        }

        private void Order_Click(object sender, EventArgs e)
        {
            showorderdeal();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Paymentdeal p = new Paymentdeal();
            p.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
              server.Service1 s = new server.Service1();
            dataGridView1.AutoGenerateColumns = false;
            string n, p, q;
            n = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            p = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
            q = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
            s.orderdeal(n, p, q);
        
        }
    }
}
