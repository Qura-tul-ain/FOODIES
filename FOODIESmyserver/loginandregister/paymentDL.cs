using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace loginandregister
{
    public class paymentDL
    {
        public static List<payment> Adresslist = new List<payment>();


        public static void addlocation(string name)
        {
            payment obj = new payment();
            obj.Adress = name;
            paymentDL.Adresslist.Add(obj);

        }

        public static bool islocation(string adress)
        {
            bool check = false;
            foreach (payment u in paymentDL.Adresslist)
            {
                if (u.Adress==adress)
                    check = true;
            }
            return check;
        }
    }
}