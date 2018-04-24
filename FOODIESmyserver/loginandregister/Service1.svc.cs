using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace loginandregister
{
    [DataContract]
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public bool login(string name, string password)
        {
            return Userdl.login(name, password);
        }


        public bool Registeration(string name, string password, string cpassword, Boolean isadmin, Boolean iscashier)
        {
            return Userdl.Registeration(name, password, cpassword, isadmin, iscashier);
        }

        public bool resetpassword(string name)
        {
            return Userdl.resetpassword(name);
        }

        public void additem(string name, string category, string price)
        {
            ItemDL.additem(name, category, price);
        }

        public  List<Item> getlist()
        {
            return ItemDL.getlist();
        }

    }
}
