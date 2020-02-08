using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo1Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car mycar = new Car();
            //Car mycar = new Car(900000);
            Car mycar = new Car("AP16dc4325","black","swift-vxi",900000);
            Console.WriteLine(mycar.ShowCar());
            Car mycar1 = new Car();
            Console.WriteLine(mycar1.ShowCar());
            Car mycar2 = new Car(500000);
            Console.WriteLine(mycar2.ShowCar());
            Console.ReadKey();

        }
    }
}
