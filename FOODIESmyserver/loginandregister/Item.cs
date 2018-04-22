using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;

namespace loginandregister
{
    [DataContract]
    public class Item
    {
       
        private string itemName;
        [DataMember]
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private string category;
         [DataMember]
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        private string price;
         [DataMember]
        public string Price
        {
            get { return price; }
            set { price = value; }
        }

    }
}