using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iairborne
{
    class Aeroplane:Helocopter,Iairbone
    {
        public new void Fly()
        {
            Console.WriteLine("Aeroplane  is flying fromderived class");

        }
    }
}
