using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPassbyValue
{
    class Program
    {
        static void ShowData(int x,int y)
        {
            int z = x + y;
            x = +5;
            y = +5;
            Console.WriteLine("{0}", z);
        }
        static void Main(string[] args)
        {
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("the elements befoe fuction are"+a+"and"+b);
            ShowData(a, b);
            Console.WriteLine("the value are when call by value is "+a+"and" +b);
            Console.ReadKey();
        }
    }
}
