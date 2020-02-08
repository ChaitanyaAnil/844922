using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismMthdovld
{
    class Program
    {
        static void Main(string[] args)
        {
            // SalesObj();
            //CalculateObj();
            SampleStaticObj();

            Console.ReadKey();
        }

        private static void SampleStaticObj()
        {
            SampleStatic ss = new SampleStatic();
            SampleStatic ss1 = new SampleStatic();
            SampleStatic.show();
        }

        private static void SalesObj()
        {
            Sales s = new Sales();
            Sales s1 = new Sales();
            s.ProductName = "cake1";
            s.Quantity = 1;
            s.Price = 500;
            Console.WriteLine("product name{0} \n product quantity {1} \n product price {2} slaes amount is{3} \n total amount is:{4}", s.ProductName, s.Quantity, s.Price, s.Saleamount, s.TotalAmount);
            s1.ProductName = "cake2";
            s1.Quantity = 2;
            s1.Price = 600;
            Console.WriteLine("product name{0} \n product quantity {1} \n product price {2} slaes amount is{3} \n total amount is:{4}", s1.ProductName, s1.Quantity, s1.Price, s1.Saleamount, s1.TotalAmount);
        }


        private static void CalculateObj()
        {
            Calculate clt = new Calculate();
            Console.WriteLine(clt.area(12));
            Console.WriteLine(clt.area(9, 9));
            Console.WriteLine(clt.area(5.7));
            Console.WriteLine(clt.area(10.5, 4.5));
        }
    }
}
