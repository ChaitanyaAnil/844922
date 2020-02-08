using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class EmployeeBase
    {
        public string name;
        protected double basepay;
        public EmployeeBase(string name,double basepay)
        {
            this.name = name;
            this.basepay = basepay;
        }
        public virtual double Cal()
        {
            return basepay;

        }
    }
}
