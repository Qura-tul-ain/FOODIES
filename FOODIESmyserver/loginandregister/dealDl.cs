using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;
using System.Web;

namespace loginandregister
{
    public class dealDl
    {
        public static double p = 0;
        public static double total = 0;
        public static double intprice, intquantity;
        public static double tax = 0;
        public static double t = 0;
        public static double f = 0;
        public static double fbill = 0;
        //varibale after deletion
        public static double dp = 0;
        public static double dt = 0; public static double df = 0;
        [DataMember]
        
        public static List<Deal> dealorderlist = new List<Deal>();
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
        public static void orderdeal(string name, string price, string quantity)
        {
            Deal d = new Deal();
            d.Item = name;
            d.Price = price;
            d.Quantity = quantity;
            dealDl.dealorderlist.Add(d);

            intprice = Convert.ToDouble(d.Price);
            intquantity = Convert.ToDouble(d.Quantity);
            p = intprice * intquantity;
            t = 0.03 * p;
            orderprice(p);
            calTax(t);
            f = p + t;
            calfinalbill(f);
            dp = total - p;
            dt = tax - t;
            df = fbill - f;


        }
        public static void deleteorderdeal(Int32 index)
        {
            dealorderlist.RemoveAt(index);
           // fbillafterdeletion();
        }
        public static List<Deal> getorderlist()
        {
            return dealDl.dealorderlist;
        }
        public static void orderprice(double x)
        {
            dealDl.total = dealDl.total + x;
        }
        public static double getorderprice()
        {
            return dealDl.total;
        }
        public static void calTax(double x)
        {
            dealDl.tax = dealDl.tax + x;
        }
        public static double gettax1()
        {
            return dealDl.tax;
        }
        public static void calfinalbill(double x)
        {
            dealDl.fbill = dealDl.fbill + x;

        }

        public static double getfinalbill()
        {
            return dealDl.fbill;
        }
      /*  public static void fbillafterdeletion()
        {
            dp = total - p;
            dt = tax - t;
            df = fbill - f;
        }*/
        public static double BILLdp()
        {
            return dealDl.dp;
        }
        public static double BILLdt()
        {
            return dealDl.dt;
        }
        public static double BILLdf()
        {
            return dealDl.df;
        }
    }
}