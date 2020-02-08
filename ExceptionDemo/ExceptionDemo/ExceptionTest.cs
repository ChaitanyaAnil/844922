using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class ExceptionTest
    {
        public int A
        {
            get;
            set;
        }
        public int B
        {
            get;
            set;
        }
      public   double SafeDivision(int a,int b)
        {
            double cal;
            A = a;
            B = b;
            if (b == 0)
                throw new System.DivideByZeroException();
            else
                cal = A / B;
            return cal;
        }
    }
}
