using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Student std = new Student("chaitanya","anil");
            //std.Name = "aman";
            std.Idno = 123;
            std.Course = ".net";
            std.Joindate = Convert.ToDateTime("01-20-2020");
            Console.WriteLine("name is{0} \n id is {1}", std.Name, std.Idno);
            Console.WriteLine("course is {0} \n joining date is {1}", std.Course, std.Joindate);
            Console.ReadKey();
        }
    }
}
