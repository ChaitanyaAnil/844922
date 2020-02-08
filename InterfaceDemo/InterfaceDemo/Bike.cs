using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Bike
    {
        public string Name
        {
            get;
            set;
        }
        public void GetDetails()
        {
            Console.WriteLine("this is bkie class method impl");
        }
    }
}
