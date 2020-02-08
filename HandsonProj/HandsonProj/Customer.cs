using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonProj
{
    class Customer
    {
       
        public string Cid
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public string  CustomerData()
        {
            return string.Format("customer id{0}:\n Name{1} :\n Address{2}:", Cid, Name, Address);
        }
    }
}
