using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loginandregister
{
    public class User
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        private string cpassword;

        public string Cpassword
        {
            get { return cpassword; }
            set { cpassword = value; }
        }
        private bool isadmin;

        public bool Isadmin
        {
            get { return isadmin; }
            set { isadmin = value; }
        }
        private bool iscashier;

        public bool Iscashier
        {
            get { return iscashier; }
            set { iscashier = value; }
        }

    }
}
