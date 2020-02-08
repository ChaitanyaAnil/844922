using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeligatesDemo
{
    class Program
    {


        //public delegate string Mydel(int x, int y);
        //public delegate string Mydel(int x);
        public delegate void Deleventhandler();
        public static event Deleventhandler handler;

        static void Main(string[] args)
        {
            // Deledemoobj();
            // AreaSquareDelg();
            handler += new Deleventhandler(Square);
            handler += new Deleventhandler(Circle);

            Console.ReadKey();

        }
        static void Circle()
        {
            double r = 12.5;
            double ar = Math.PI * r * r;
            Console.WriteLine(ar);
        }
        static void Square()
        {
            double s = 12;
            double res = s * s;
            Console.WriteLine(res);
        }

        /*  private static void AreaSquareDelg()
          {
              string Area(int x)
              {
                  return String.Format("area of square is " + (x * x));
              }
              Console.WriteLine("enter a side of square to calulate are...");
              int input = int.Parse(Console.ReadLine());//creating delegate
              Mydel del = new Mydel(Area);//creating delegate
              //instanciarting delegate by creating obj
              Console.WriteLine(del(input));
          }
          */
        /*private static void Deledemoobj()
        {
            string Add(int x, int y)
            {
                int z = x + y;
                return string.Format("{0} + {1} = {2}", x, y, z);
            }
            string Sub(int x, int y)
            {
                int z = x - y;
                return string.Format("{0} -{1} = {2}", x, y, z);
            }
            Mydel del = new Mydel(Add);
            del += new Mydel(Sub);
            Console.WriteLine(del(10, 20));
            del -= new Mydel(Sub);
            Console.WriteLine(del(10, 20));
        }*/
    }
}