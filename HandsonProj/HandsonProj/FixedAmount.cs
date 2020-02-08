using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonProj
{
    class FixedAmount:BankAmount
    {
        public override double IntrestAmout(double cal)
        {
            double Years = 2;
           double d = ( cal* 3 * Years) / 100;
            double total = cal + d;
            Console.WriteLine("additianl interst @3% is:" + d);
            Console.WriteLine("total intrest is {0}", total);
            return d;
        }

    }
}
