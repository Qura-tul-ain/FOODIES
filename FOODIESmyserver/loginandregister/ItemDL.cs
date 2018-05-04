using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace loginandregister
{
 [DataContract]  
    public class ItemDL
    {
        public static int p=0 ;
        public static int p1, p2;
        [DataMember]
      
        public static List<Item> items = new List<Item>();
        public static List<Item> order = new List<Item>();
        public static int totalprice=0;

        public static void additem(string name, string category, string price)
        {
            Item ab = new Item();
            ab.ItemName = name;
            ab.Category = category;
            ab.Price = price;
            ItemDL.items.Add(ab);

        }
        public static List<Item> getlist()
        {
            return ItemDL.items;

        }

        public static List<Item> getorder()
        {
            return ItemDL.order;

        }
        public static void orderitem(string name,string category,string price,string quantity)
        {
            Item a = new Item();
            a.ItemName = name;
            a.Category = category;
            a.Price = price;
            a.Quantity = quantity;
            ItemDL.order.Add(a);

            p1 = Convert.ToInt32(a.Price);
            p2 = Convert.ToInt32(a.Quantity);
            p = p1 * p2;

            Tprice(p);

        }

        public static void Tprice(int x)
        {

            ItemDL.totalprice = ItemDL.totalprice + x;
        }

        public static int getprice()
        {
            return ItemDL.totalprice;

        }


    }
}