using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace loginandregister
{
    public class status
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private bool isdeliver;

        public bool Isdeliver
        {
            get { return isdeliver; }
            set { isdeliver = value; }
        }
        private bool ispaid;

        public bool Ispaid
        {
            get { return ispaid; }
            set { ispaid = value; }
        }
    }
}