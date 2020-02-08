using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iairborne
{
    class Circle:Shape
    {
        public int R
        {
            get;
            set;
        }
        public override double Area()
        {
            return (R * R * Math.PI);
        }

    }
}
