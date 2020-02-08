using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsHndsonCalc
{
    class Calculator
    {
        int n1, n2;
        public Calculator()
        {
            Console.WriteLine("O arg contructor");
        }
        public Calculator(int n1,int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
        }
        public int Add()
        {
            return n1 + n2;
        }
        public int Difference()
        {
            return n1 - n2;
        }
            public int Multiply()
            {
                return n1 * n2;
            
            }
        public int Divison()
        {
            return n1 / n2;
        }
        

    }
    }
