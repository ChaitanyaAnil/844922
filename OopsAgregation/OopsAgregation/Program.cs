using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAgregation
{
    class Program
    {
        static void Main(string[] args)
        {
            Department d = new Department(1234,"IT");
            Employee e = new Employee(12, "smith", "chennai", d);
            e.Display();
            Console.ReadKey();
        }
    }
}
