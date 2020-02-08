using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppPassbyValue
{
    class Program
    {
        static int ShowData(ref int a, ref int b)
        {

            int z = a + b;
            a +=5;
            b +=5;
            Console.WriteLine("{0}", z);
            return z;
        }
        static void Main(string[] args)
        {
            int a=9, b=10;
            
            Console.WriteLine("the elements befoe fuction are" + a + "and" + b);
            ShowData(ref a, ref b);
            Console.WriteLine("the value are when call by ref  is " + a + "and" + b);
            Console.ReadKey();
        }
    }
}
