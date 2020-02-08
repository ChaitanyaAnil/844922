using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product { Id = 1, Name = "mobile", Price = 23399};
            Console.WriteLine("{0} \n{1}\n{2} ", p.Id, p.Name, p.Price);
            Console.ReadKey();
        }
    }
}
