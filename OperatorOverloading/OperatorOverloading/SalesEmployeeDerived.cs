using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class SalesEmployeeDerived :EmployeeBase
    {
        private double salesBonus;
        public  SalesEmployeeDerived(string name, double basepay, double salesBonus) : base(name,basepay)
        {
            this.salesBonus = salesBonus;
            
        }
        public override double Cal()
        {
            return salesBonus + basepay;
        }
    }
}
