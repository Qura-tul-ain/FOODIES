using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loginandregister
{
    public class dealDl
    {
        public static List<Deal> deallist = new List<Deal>();
        public static void adddeal(string name, string price)
        {
            Deal ab = new Deal();
            ab.Item = name;
            ab.Price = price;
            dealDl.deallist.Add(ab);

        }

        public static List<Deal> getdeal()
        {
            return dealDl.deallist;
        }
    }
}