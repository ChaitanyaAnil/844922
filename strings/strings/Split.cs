using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Split
    {
        public string[] Getstring(string str)
        {
            string[] str1 = str.Split();
            //Console.WriteLine(str1.ToArray());
            return str1;
        }
    }
}
