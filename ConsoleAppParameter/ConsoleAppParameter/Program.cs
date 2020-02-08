using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppParameter
{
    class Program
    {
        static string Greet(string s,int n)
        {
            string res;
            res = string.Format("your ame is {0} and age is {1}", s, n);
            Console.WriteLine(res);
           
            return res;
        }
        static void Main(string[] args)
        {
            int n;
            string s;
            Console.WriteLine("enter name");
            s = Console.ReadLine();
            Console.WriteLine("enter age");
            n = int.Parse(Console.ReadLine());
            Greet(s,n);
            Console.ReadKey();

        }
    }
}
