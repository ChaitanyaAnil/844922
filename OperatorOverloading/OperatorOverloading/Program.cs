using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //MethodOverloadObj();
            MethodOverrideobj();
            Console.ReadKey();
        }

        private static void MethodOverrideobj()
        {
            EmployeeBase eb = new EmployeeBase("smith", 50000);
            SalesEmployeeDerived sed = new SalesEmployeeDerived("john", 25000, 10000);
            Console.WriteLine("employee" + eb.Cal());
            Console.WriteLine("salesmployee" + sed.Cal());
            Console.WriteLine(" sales employ details:{0}", sed);
        }

        private static void MethodOverloadObj()
        {
            Demo d1 = new Demo(10, 50);
            d1.ShowData();
            Demo d2 = new Demo(20, 100);
            d2.ShowData();
            Demo t1 = new Demo();
            t1 = d1 + d2;
            t1.ShowData();
        }
    }
}
