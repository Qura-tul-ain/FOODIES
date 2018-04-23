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

        public static bool Registeration(string name,string password,string cpassword,bool isadmin,bool iscashier)
        {
            User obj = new User();

            Boolean ac = false;
            Boolean ab = false;
            Boolean omg = false;
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
        public static bool login(string name,string password)
        {
            bool check = false;
            foreach (User u in Userdl.RegisterUser)
            {
                if (u.Name==name && u.Password==password)
                    check = true;
            }
            return check;
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