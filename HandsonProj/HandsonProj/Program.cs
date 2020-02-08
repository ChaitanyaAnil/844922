using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonProj
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer
            {
                Cid = "1234",
                Name = "smith",
                Address = "chennai"
            };

            BankAmount b = new BankAmount
            { Accno = 12344567,
                Balance = 10000,
                c = c1,
            };
            b.ShowDetails();
            b.IntrestAmout(b.Balance);
            FixedAmount f = new FixedAmount();
            f.IntrestAmout(b.Balance);
            Console.ReadKey();

           
            

        
       
            
        }
    }
}
