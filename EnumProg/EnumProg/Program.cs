using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumProg
{

   
    class Program

    {
        enum Department
        {
            physics = 10,
        chemistry,
        Mathematics = 15,
        biology = 18

        }
        enum Weekdays
        {
            sun=1,mon,tue,wed,thu,fri,sat
        }
        static void Main(string[] args)
        {
            Console.WriteLine("department details are{0}", Department.physics);
            Console.WriteLine("department details are{0}", Department.chemistry);
            Console.WriteLine("department details are{0}", Department.Mathematics);
            Console.WriteLine("department details are{0}", Department.biology);

            Console.WriteLine("the weekdays are {0}", Weekdays.sun);
            Console.WriteLine("the weekdays are {0}", Weekdays.mon);
            Console.WriteLine("the weekdays are {0}", Weekdays.tue);
            Console.WriteLine("the weekdays are {0}", Weekdays.wed);
            Console.WriteLine("the weekdays are {0}", Weekdays.thu);
            Console.WriteLine("the weekdays are {0}", Weekdays.fri);
            Console.WriteLine("the weekdays are {0}", Weekdays.sat);
            Console.WriteLine("the weekdays are {0}", (int)Weekdays.sun);
            Console.WriteLine("the weekdays are {0}", (int)Weekdays.mon);
            Console.WriteLine("the weekdays are {0}", (int)Weekdays.tue);
            Console.WriteLine("the weekdays are {0}", (int)Weekdays.wed);
            Console.WriteLine("the weekdays are {0}", (int)Weekdays.thu);
            Console.WriteLine("the weekdays are {0}", (int)Weekdays.fri);
            Console.WriteLine("the weekdays are {0}", (int)Weekdays.sat);
         
            Console.ReadKey();
        }
    }
}
