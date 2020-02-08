using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppFactorail
{
    class Program
    {
       static  int factorial(int n)
        {
            if (n == 0)
                return 1;
            else
               return  n * (factorial(n - 1));
        }
           
        
        static void Main(string[] args)
        {
            int n, i, fact=1;
            
            Console.WriteLine("enter number");
            n = int.Parse(Console.ReadLine());
        fact = factorial(n);
        Console.WriteLine("facorial is{0}", fact);
        Console.ReadKey();

        }
    }
}
