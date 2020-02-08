using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppControlStruct
{
    class Program
    {
        static void add(int a,int b)
        {
            Console.WriteLine("adddition is {0}", a + b);
        }
        static void sub(int a, int b)
        {
            Console.WriteLine("sub  is {0}", a - b);
        }
        static void multiply(int a, int b)
        {
            Console.WriteLine("multiplication  is {0}", a * b);
        }
        static void div(int a, int b)
        {
            Console.WriteLine("division  is {0}", a / b);
        }
        static void Main(string[] args)
        {
            int a, b, ch;
            Console.WriteLine("enter first number");
            a=int.Parse(Console.ReadLine());
            if(a>=10)
            {
                Console.WriteLine("please enetr first number between 1to 1o ");
                a = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("enter second  number");
            b = int.Parse(Console.ReadLine());
            if (b>=10)
            {
                Console.WriteLine("please enetr first number between 1to 1o ");
                b = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("please enter your choice 1.add 2.sub. 3.multiply.4.div 5.exit");
            ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:add(a, b);
                    break;
                case 2:sub(a, b);
                    break;
                case 3:multiply(a, b);
                    break;
                case 4:div(a, b);
                    break;
                
                default: Console.WriteLine("please select the choic between 1 to 5");
                    break;

             }
            Console.ReadKey();

        }
    }
}
