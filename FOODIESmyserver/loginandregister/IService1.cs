using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace loginandregister
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Registeration(string name, string password, string cpassword, Boolean isadmin, Boolean iscashier);

        [OperationContract]
        bool login(string name,string password);

        [OperationContract]
        bool resetpassword(string name);
        [OperationContract]
        List<User> getusers();
        [OperationContract]
        void onlyusers(string name);

        [OperationContract]
        void additem(string name, string category, string price);
        [OperationContract]
        void delete(Int32 index);
        [OperationContract]
         void adddeal(string name, string price);
        [OperationContract]
        List<Item> getlist();

        [OperationContract]
        string GetData(int value);

        [OperationContract]
        List<Deal> getdeal();

        [OperationContract]
        void orderitem(string name, string category, string price, string quantity);

        [OperationContract]
        List<Item> getorder();
        [OperationContract]
        void Tprice(int x);
        [OperationContract]
        int getprice();
        [OperationContract]
        int gettotalprice();

        [OperationContract]
        int gettax();

        [OperationContract]
        void addlocation(string name);
        [OperationContract]
        bool islocation(string adress);
        //for deals
        [OperationContract]
        void orderdeal(string name, string price, string quantity);

        [OperationContract]
        void orderprice(int x);

        [OperationContract]
        List<Deal> getorderlist();

        [OperationContract]
        double getorderprice();

        [OperationContract]
        void calTax(double x);

        [OperationContract]
        double getfinalbill();

        [OperationContract]
        void calfinalbill(double x);

        [OperationContract]

        double gettax1();



        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // for location
        [OperationContract]
        List<payment> getlocation();

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
