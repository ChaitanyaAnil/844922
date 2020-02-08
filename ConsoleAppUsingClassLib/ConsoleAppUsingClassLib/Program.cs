using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibCalculation;

namespace ConsoleAppUsingClassLib
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculation cal = new Calculation();
            cal.No1 = 50;
            cal.No2 = 40;
            Console.WriteLine(cal.Add());
            Console.WriteLine(cal.Diff());
            Console.WriteLine(cal.Multiply());
            Console.WriteLine(cal.Divison());
            Console.ReadKey(); 
        }
    }
}
