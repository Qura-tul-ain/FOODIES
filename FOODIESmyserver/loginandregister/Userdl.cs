using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Collections;



namespace loginandregister
{
    public class Userdl
    {
        public static List<User> RegisterUser = new List<User>();
        public static List<User> RegisterAdmin= new List<User>();
        public static List<User> RegisterCashier = new List<User>();


        public static bool RegisterationUser(string name,string password,string cpassword,bool isadmin,bool iscashier)
        {
            User obj = new User();

            Boolean ac = false;
            Boolean ab = false;
          //  Boolean omg = false;
            foreach (User b in Userdl.RegisterUser)
            {
                if (b.Name == name)
                {
                    ac = true;

                }
            }
            if (ac)
            {
                return ac;
            }


            else
            {

                obj.Name = name;
                obj.Password = password;
                obj.Cpassword = cpassword;
                obj.Isadmin = isadmin;
                obj.Iscashier = iscashier;
                if(obj.Password != obj.Cpassword)
                {
                    ab = true;
                }
                if (ab)
                {
                    return ab;

                }
                else
                {
                    Userdl.RegisterUser.Add(obj);
                    return ac;
                }
               
            }
        }


        public static bool RegisterationAdmin(string name, string password, string cpassword, bool isadmin, bool iscashier)
        {
            User obj = new User();

            Boolean ac = false;
            Boolean ab = false;
            //  Boolean omg = false;
            foreach (User b in Userdl.RegisterUser)
            {
                if (b.Name == name)
                {
                    ac = true;

                }
            }
            if (ac)
            {
                return ac;
            }


            else
            {

                obj.Name = name;
                obj.Password = password;
                obj.Cpassword = cpassword;
                obj.Isadmin = isadmin;
                obj.Iscashier = iscashier;
                if (obj.Password != obj.Cpassword)
                {
                    ab = true;
                }
                if (ab)
                {
                    return ab;

                }
                else
                {
                    Userdl.RegisterAdmin.Add(obj);
                    return ac;
                }

            }
        }




        public static bool RegisterationCashier(string name, string password, string cpassword, bool isadmin, bool iscashier)
        {
            User obj = new User();

            Boolean ac = false;
            Boolean ab = false;
            //  Boolean omg = false;
            foreach (User b in Userdl.RegisterUser)
            {
                if (b.Name == name)
                {
                    ac = true;

                }
            }
            if (ac)
            {
                return ac;
            }


            else
            {

                obj.Name = name;
                obj.Password = password;
                obj.Cpassword = cpassword;
                obj.Isadmin = isadmin;
                obj.Iscashier = iscashier;
                if (obj.Password != obj.Cpassword)
                {
                    ab = true;
                }
                if (ab)
                {
                    return ab;

                }
                else
                {
                    Userdl.RegisterCashier.Add(obj);
                    return ac;
                }

            }
        }

        public static bool loginUser(string name,string password)
        {
            bool check = false;
            foreach (User u in Userdl.RegisterUser)
            {
                if (u.Name==name && u.Password==password)
                    check = true;
            }
            return check;
        }

        public static bool loginAdmin(string name, string password)
        {
            bool check = false;
            foreach (User u in Userdl.RegisterAdmin)
            {
                if (u.Name == name && u.Password == password)
                    check = true;
            }
            return check;
        }


        public static bool loginCashier(string name, string password)
        {
            bool check = false;
            foreach (User u in Userdl.RegisterCashier)
            {
                if (u.Name == name && u.Password == password)
                    check = true;
            }
            return check;
        }

       
        public static List<User> getuser()
        {
            return Userdl.RegisterUser;
        }

        public static bool resetpassword(string name)
        {
            bool True = false;
            foreach (User a in Userdl.RegisterUser)
            {
                if (a.Name ==name)
                {
                    // pass = true;
                    a.Password = "123";
                    True = true; 
                }
                else
                {
                    True = false;
                }
            }
            return True;
        }
    }
}