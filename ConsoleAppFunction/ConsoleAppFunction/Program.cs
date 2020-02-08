using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFunction
{
    class Program
    {
        static void Add(int a, int b)
        {
            int c;
            c = a + b;
            Console.WriteLine(" the addition of two numbers is {0}", c);
        }
        static int  multiply(int a,int b)
        {
            int prod = a * b;
            Console.WriteLine(" the addition of two numbers is {0}", prod);
            return prod;
        }
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Add(a,b);
            multiply(a, b);
            Console.ReadKey();

        }
        
    }
}
