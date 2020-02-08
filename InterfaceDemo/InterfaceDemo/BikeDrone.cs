using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class BikeDrone:Bike,IDrone 
    {
        public new void GetDetails()
        {
            Console.WriteLine("implented in BIKE DRONE Class");
        }
        public string show(string res)
        {
            Name = res;
            return string.Format(""+Name);
        }
    }
}
