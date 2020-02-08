using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleClass
{
    partial class c
    {
        string Name;
        int id;
        public  c(string a,int b)
        {
            this.Name = a;
            this.id = b;
        }

    }
    partial class c
    {
     public void display()
        {
            Console.WriteLine(" name is" + Name);
            Console.WriteLine("  id is" + id);

        }
    }
    class Program
    {
      public   static void Main(string[] args)
        {
            c obj = new c("anil",1234);
           
            obj.display();

            Console.ReadKey();
        }
    }
}


