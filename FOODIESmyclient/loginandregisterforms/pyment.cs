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
            priceShow();
        }
        public  void priceShow()
        {
            int getprice;
            Boolean getpriceresult;
            server.Service1 o = new server.Service1();
            o.getprice(out getprice,out getpriceresult);
            textBox1.Text = Convert.ToString(getprice);
        }
    }
}
