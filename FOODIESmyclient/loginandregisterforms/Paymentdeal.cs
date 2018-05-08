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
    public partial class Paymentdeal : Form
    {
        public Paymentdeal()
        {
            InitializeComponent();
        }

        private void Paymentdeal_Load(object sender, EventArgs e)
        {
            //location
            server.Service1 oo = new server.Service1();
            BindingSource data = new BindingSource();
            data.DataSource = oo.getlocation();
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "Adress";
          
            //
            double getorderpriceResult;
            bool getorderpriceResultspecified;
            server.Service1 s = new server.Service1();
            s.getorderprice(out getorderpriceResult, out getorderpriceResultspecified);
            textBox1.Text = Convert.ToString(getorderpriceResult);
            showtax();
            showfinalbill();
        }
        public void showtax()
        {
            double gettaxResult;
            bool gettaxResultSpecified;
            server.Service1 s = new server.Service1();
            s.gettax1(out gettaxResult, out gettaxResultSpecified);
            textBox2.Text = Convert.ToString(gettaxResult);

        }
        public void showfinalbill()
        {
            double finalbillResult;
            bool finalbillResultSpecified;
            server.Service1 s = new server.Service1();
            s.getfinalbill(out finalbillResult, out finalbillResultSpecified);
            textBox3.Text = Convert.ToString(finalbillResult);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            bool islocation;
            bool islocationresult;
            server.Service1 o = new server.Service1();
            o.islocation(comboBox1.Text, out islocation, out islocationresult);
            if (islocation == true)
            {
                MessageBox.Show("Order send to nearest branch");
            }
            else
            {
                MessageBox.Show("Select nearest location");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {  double BILLdfResult;
           bool BILLdfResultSpecified;
           double BILLdpResult;
           bool BILLdpResultSpecified;
           double BILLdtResult;
           bool BILLdtResultSpecified;
            server.Service1 s = new server.Service1();
            s.BILLdf(out BILLdfResult,out BILLdfResultSpecified);
            textBox3.Text = Convert.ToString(BILLdfResult);
            s.BILLdp(out BILLdpResult, out BILLdpResultSpecified);
            textBox1.Text = Convert.ToString(BILLdpResult);
            s.BILLdt(out BILLdtResult, out BILLdtResultSpecified);
            textBox2.Text = Convert.ToString(BILLdtResult);
        }
    }
}
