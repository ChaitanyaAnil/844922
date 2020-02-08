using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task16
{
    class Circle
    {
        private double radius;
        string st;
        public double Calculate(Func<double, double> mp)
        {
            return mp(radius);

        }
        public string UpperCase(Func<string,string> up)

        {
            // return string.Format(up(st));
            return up(st);
        }
    }
}
