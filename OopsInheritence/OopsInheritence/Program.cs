using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsInheritence
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v = new Vehicle();
            v.ShowVechile();
            v.show(); ;
            Train t = new Train();
            t.ShowTrain();
            t.show();
            Ship s = new Ship();
            s.ShowShip();
            s.show();
            Console.ReadKey();
        }
    }
}
