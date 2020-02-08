using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tak16DelgFuncTriangle();
            LamdaExpAsParamMethodtoM();
            Console.ReadKey();
        }

        private static void LamdaExpAsParamMethodtoM()
        {
            Circle circle = new Circle();
            Console.WriteLine("enter rdius");
            double p = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(circle.Calculate(r => 2 * Math.PI * p));
            Console.WriteLine();
            Console.WriteLine(circle.Calculate(r => Math.PI * p * p));
            Console.WriteLine(circle.Calculate(a => p * p * p));
            Console.WriteLine("enter a string in loer case");
            string s = Console.ReadLine();
            Console.WriteLine(circle.UpperCase(a => s.ToUpper()));
            Console.WriteLine("enter a string in upper  case");
            string t = Console.ReadLine();
            Console.WriteLine(circle.UpperCase(a => t.ToLower()));

        }

        private static void Tak16DelgFuncTriangle()
        {
            Func<double, double, double> AreaTiangle = (x, y) => 0.5 * x * y;
            Console.WriteLine("area of triangle is" + AreaTiangle(10, 15));
        }
    }
}
