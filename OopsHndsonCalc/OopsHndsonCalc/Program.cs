using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OopsHndsonCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator cal = new Calculator(10, 5);
     

            Console.WriteLine("additionn is "+cal.Add());
            Console.WriteLine("difference is " + cal.Difference());
            Console.WriteLine("multiplication is " + cal.Multiply());
            Console.WriteLine("divison is" + cal.Divison());
            Console.ReadKey();
        }
    }
}
