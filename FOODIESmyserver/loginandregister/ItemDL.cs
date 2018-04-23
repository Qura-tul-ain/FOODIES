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
     [DataMember]
      
        public static List<Item> items = new List<Item>();
        public static void additem(string name, string category, string price)
        {
            Item ab = new Item();
            ab.ItemName = name;
            ab.Category = category;
            ab.Price = price;
            ItemDL.items.Add(ab);

        }
        public static Item getlist()
        {
            return  items;
        }

    }
}