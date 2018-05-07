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
            bs.DataSource = o.getusers();
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
        
    }
}
