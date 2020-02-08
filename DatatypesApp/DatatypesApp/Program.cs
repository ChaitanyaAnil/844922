using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatatypesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 255;
            short s = 359;
            int n = 999;
            uint un = 9999;
            long l = 10398959;
            ulong ul = 10345566777;
            float f = 10.958122f;
            decimal m = 109568.99m;
            DateTime dt = DateTime.Now;
            Console.WriteLine(" the value of data type byte is {0}", b);
            Console.WriteLine(" the value of data type short is {0}", s);
            Console.WriteLine(" the value of data type int is {0}", n);
            Console.WriteLine(" the value of data type uint  is {0}", un);
            Console.WriteLine(" the value of data type long is {0}", l);
            Console.WriteLine(" the value of data type ulong e is {0}", ul);
            Console.WriteLine(" the value of data type float is {0}", f);
            Console.WriteLine(" the value of data type decimal  is {0}", m);
            Console.WriteLine(" the current date of system, is  {0}", dt);
            Console.ReadKey();
        }
    }
}
