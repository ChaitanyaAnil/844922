using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonPropauto
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvCmtoInch();
            Console.ReadKey();
        }

        private static void ConvCmtoInch()
        {
            Scale s = new Scale();
            s.CalInch(10);
            s.CalCm(11);
            s.display();
        }
    }
}
