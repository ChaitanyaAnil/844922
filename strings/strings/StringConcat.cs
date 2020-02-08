using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class StringConcat
    {
        public string Firstname
        {
            get;
            set;
        }
        public string Lastname
        {
            get;
            set;
        }
        public string M2(string fn, string ln)
        {
            string fullname;
            fullname = string.Concat(fn,ln);
            return string.Format(" full name is " + fullname);
        }
    }
}
