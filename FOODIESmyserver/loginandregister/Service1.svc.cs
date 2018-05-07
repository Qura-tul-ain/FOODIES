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

        public bool loginAdmin(string name, string password)
        {
            return Userdl.loginAdmin(name, password);
        }

        public bool loginUser(string name, string password)
        {
            return Userdl.loginUser(name, password);
        }


        public List<User> getuser()
        {
            return Userdl.getuser();
        }

        public bool loginCashier(string name, string password)
        {
            return Userdl.loginCashier(name, password);
        }




        public bool RegisterationUser(string name, string password, string cpassword, Boolean isadmin, Boolean iscashier)
        {
            return Userdl.RegisterationUser(name, password, cpassword, isadmin, iscashier);
        }

        public bool RegisterationAdmin(string name, string password, string cpassword, Boolean isadmin, Boolean iscashier)
        {
            return Userdl.RegisterationAdmin(name, password, cpassword, isadmin, iscashier);
        }

        public bool RegisterationCashier(string name, string password, string cpassword, Boolean isadmin, Boolean iscashier)
        {
            return Userdl.RegisterationCashier(name, password, cpassword, isadmin, iscashier);
        }

        public bool resetpassword(string name)
        {
            return Userdl.resetpassword(name);
        }

        public void additem(string name, string category, string price)
        {
            ItemDL.additem(name, category, price);
        }
        public void delete(Int32 index)
        {
            ItemDL.delete(index);
        }

        public List<Item> getlist()
        {
            return ItemDL.getlist();
        }

       
        //deals
        public void adddeal(string name, string price)
        {
            dealDl.adddeal(name, price);
        }
        public List<Deal> getdeal()
        {
            return dealDl.getdeal();
        }
        public void orderdeal(string name, string price, string quantity)
        {
            dealDl.orderdeal(name, price, quantity);
        }
        public void orderprice(int x)
        {
            dealDl.orderprice(x);
        }
        public double getorderprice()
        {
            return dealDl.getorderprice();
        }
        public List<Deal> getorderlist()
        {
            return dealDl.getorderlist();
        }
        public void calTax(double x)
        {
            dealDl.calTax(x);
        }
        public double gettax1()
        {
            return dealDl.gettax1();

        }
        public double getfinalbill()
        {
            return dealDl.getfinalbill();
        }
        public void calfinalbill(double x)
        {
            dealDl.calfinalbill(x);
        }

        //deals_end
        public void orderitem(string name, string category, string price, string quantity)
        {
            ItemDL.orderitem(name, category, price, quantity);
        }
        
        public  List<payment> getlocation()
        {
            return paymentDL.Adresslist;
        }

        public List<Item> getorder()
        {
            return ItemDL.getorder();
        }

        public void Tprice(int x)
        {
            ItemDL.Tprice(x);
        }

        

        public int getprice()
        {
            return ItemDL.getprice();
        }

        public int gettotalprice()
        {
            return ItemDL.gettotalprice();
        }
        public int gettax()
        {
            return ItemDL.tax;
        }
        public void addlocation(string name)
        {
            paymentDL.addlocation(name);
        }

        public bool islocation(string adress)
        {
           return paymentDL.islocation(adress);
        }

    }
}
