using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Doit:Ihello
    {
        public void Getit()
        {
            Console.WriteLine("method executed from impl class ");
        }
    }
}
