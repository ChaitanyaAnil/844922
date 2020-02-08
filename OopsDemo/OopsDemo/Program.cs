using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Program
    {
         static void Main(string[] args)
        {
            //create an object for class Trainee
            Trainee tr = getTrobj();
            //Trainee tr1 = getTr1obj();
            Console.WriteLine("object tr hasch code is" + tr.GetHashCode());
            //Console.WriteLine("object tr1 hasch code is" + tr1.GetHashCode());
            Console.ReadKey();

        }

        private static Trainee getTr1obj()
        {
            Trainee tr1 = new Trainee();
            tr1.GetData("prasad", "EMP034", "chennai", 22);
            tr1.ShowData();
            return tr1;
        }

        private static Trainee getTrobj()
        {
            Trainee tr = new Trainee();
            tr.GetData("anil", "EMP922", "Chennai", 22);
            tr.ShowData();
            return tr;
        }
    }
}
