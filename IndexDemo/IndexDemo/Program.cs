using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Genericcls<string>();
            data[0] = "product details";
            Console.WriteLine(data[0]);
            var pdetails = new Genericcls<Product>();
            pdetails[0] = new Product
            {
                Id = 123,
                Name = "mobile",
                Price = 20000
            };
            Console.WriteLine(+pdetails[0].Id +"," +pdetails[0].Name+ pdetails[0].Price);
            Console.ReadKey();
        }

    }
}
