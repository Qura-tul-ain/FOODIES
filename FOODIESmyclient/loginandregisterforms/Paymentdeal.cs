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
    }
}
