using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppLoopstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1, n;
            Console.WriteLine("emter the number to multiply");
            n = int.Parse(Console.ReadLine());
            for (i = 1; i < 10; i++)
            {


                Console.WriteLine("{0}*{1}={2}", n, i, n * i);
            }
            Console.ReadKey();
        }
    }
}
