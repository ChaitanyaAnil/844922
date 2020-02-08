using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringOperationsClsLib;

namespace ConsoleAppClsLibSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter firstname");
            string inp1 = Console.ReadLine();
            Console.WriteLine("enter Lastname");
            string inp2 = Console.ReadLine();


            LibString ls = new LibString
            {
                Fname = inp1,
                Lname = inp2

            };
            Console.WriteLine(ls.FullName());
            Console.ReadKey();

        }
    }
}
