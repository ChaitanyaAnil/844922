using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonPropauto
{
    class Scale
    {
        private double cm;
        double res1;
        double res2;
        public double Inch
        {
            get
            {
                return cm;
            }
            set
            {
                value = cm;
            }
        }
        public double CalInch(double cm)
        {


            res1 = cm * 0.3937;
            return res1;
        }
        public double CalCm(double inc)
        {
           
             res2 = inc * 2.54;
            return res2;
        }
        public void display()
        {
            Console.WriteLine(" cm to inch is {0}inch", res1);
            Console.WriteLine("inch to cm is {0}cm", res2);
        }
    }
}
