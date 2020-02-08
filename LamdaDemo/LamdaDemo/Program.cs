using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;

namespace LamdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, double, double> Calc = (x, y) => x * y;
            Func<int, int> Square = x => x * x;
            
            Console.WriteLine(Calc(10, 12.8));
            Console.WriteLine(Square(4));
            LamdaLinqOrdr();
            Console.ReadKey();

        }
        private static void LamdaLinqOrdr()
        {
            int[] nos = { 2, 9, 5, 1,7,4 };
            var sort = nos.OrderBy(x => x);
            var sqr = sort.Select(x => x * x);
            string s = "hello extension method";
            int i = s.WordCount();
            Console.WriteLine(i);
            var maxsqr = sqr.Max();
            
            Console.WriteLine(string.Join("  ", sort));
            Console.WriteLine(string.Join("  ", sqr));
            Console.WriteLine(string.Join("  ", maxsqr));
           
        }
    }
}
