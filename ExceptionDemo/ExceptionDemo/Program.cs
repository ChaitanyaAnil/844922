using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program:ExceptionTest
    {
        static void Main(string[] args)
        {
            ExceptionTest et = new ExceptionTest
            {A=20,
            B=0
            };
            double res ;
            try
            {
                res = et.SafeDivision(20, 0);
                Console.WriteLine("{0} is div by{1} ={2}", et.A, et.B, res);
                

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("it try to divide by zero in denominator variable B");
                Console.WriteLine(e.StackTrace);
                
            }
            Console.ReadKey();
        }
    }
}
