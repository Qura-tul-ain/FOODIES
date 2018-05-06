using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loginandregister
{
    public class Deal
    {
        private string item;

        public string Item
        {
            get { return item; }
            set { item = value; }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        private string quantity;

        public string Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
     
    }
}