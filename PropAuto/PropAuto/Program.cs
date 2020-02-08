using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropAuto
{
    class Program
    {
        static void Main(string[] args)
        {
            TimePeriod tp = new TimePeriod();
            tp.Hours = 15;
            Console.WriteLine("hours {0}", tp.Hours);
            tp.ShowSeconds();
            Console.ReadKey();
        }
    }
}
