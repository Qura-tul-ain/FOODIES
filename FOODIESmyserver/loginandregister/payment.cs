using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
namespace loginandregister
{
    [DataContract]
    public class payment
    {
        private string adress;
        [DataMember]
        public string Adress
        {
            get
            {
                return adress;
            }

            set
            {
                adress = value;
            }
        }
    }
}