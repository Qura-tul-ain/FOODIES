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
    public partial class pyment : Form
    {
        public pyment()
        {
            InitializeComponent();
      
        }

        private void pyment_Load(object sender, EventArgs e)
        {
            server.Service1 o = new server.Service1(); server.Service1 oo = new server.Service1();
            BindingSource data = new BindingSource();
            data.DataSource = oo.getlocation();
           comboBox1.DataSource = data;
           comboBox1.DisplayMember = "Adress";
           
        }
        public  void priceShow()
        {
            int getprice;
            int gettax;
            int gettotalprice;
            Boolean getpriceresult;
            Boolean gettotalpriceresult;
            Boolean gettaxresult;

            server.Service1 o = new server.Service1();
            o.cal();
            o.getprice(out getprice,out getpriceresult);
            textBox1.Text = Convert.ToString(getprice);
            o.getprice(out gettotalprice, out gettotalpriceresult);
            o.gettax(out gettax, out gettaxresult);
            textBox2.Text = Convert.ToString(gettax);
            o.gettotalprice(out gettotalprice, out gettotalpriceresult);
            int totalprice = gettotalprice;
            totalprice= gettax+getprice;
            textBox3.Text = Convert.ToString(totalprice);


        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool islocation;
            bool islocationresult;
            server.Service1 o = new server.Service1();
            o.islocation(comboBox1.Text, out islocation, out islocationresult);
            if(islocation==true)
            {
                MessageBox.Show("Order send to nearest branch");
                last oo = new last();
                this.Hide();
                oo.Show();
            }
            else
            {
                MessageBox.Show("Select nearest location");
            }
            
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            menu o = new menu();
            this.Hide();
            o.show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceShow();


        }
    }
}
