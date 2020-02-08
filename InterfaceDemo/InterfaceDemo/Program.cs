using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoInterfaceObj();
            Bike b = new Bike { Name = "pulsar"  };
          
           // b.GetDetails();
          
           
            BikeDrone bd = new BikeDrone();
           
            IDrone id1 = bd;
            bd.GetDetails();
            Console.WriteLine(bd.show(b.Name));
            id1.GetDetails();


            Console.ReadKey();
        }

        private static void DemoInterfaceObj()
        {
            Doit d = new Doit();
            Ihello ih = d;
            d.Getit();
            ih.Getit();
        }
    }
}
