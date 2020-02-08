using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iairborne
{
    class Program:Shape
        //Aeroplane,Iairbone
    {
        static void Main(string[] args)
        {
            GetInterfaceObj();
          //  GetABstractObj();

            Console.ReadKey();
        }

        private static void GetABstractObj()
        {
            Circle c = new Circle { R = 5 };
            Console.WriteLine(c.Area());
        }

        private static void GetInterfaceObj()
        {
            Helocopter h = new Helocopter();
            h.Fly();
            Aeroplane a = new Aeroplane();
            a.Fly();
            Iairbone i = h;
            i.Fly();
            Iairbone i1 = a;
            i1.Fly();
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }
    }
}
