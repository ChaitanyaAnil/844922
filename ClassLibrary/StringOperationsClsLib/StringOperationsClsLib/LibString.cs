using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperationsClsLib
{
    public class LibString
    {
        public string Fname
        {
            get;
            set;
        }
        public string Lname
        {
            get;
            set;
        }
        public string FullName()
        {
            return string.Format("full name is: {0} ", string.Concat(Fname,Lname));
        }
    }
}
