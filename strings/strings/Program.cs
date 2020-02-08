using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringJionObj();
            // GetConcatOBJ();
            Console.WriteLine("enter long string");
            string input= Console.ReadLine();
            Split s = new Split();
            string[] res = s.Getstring(input);
            foreach(string s1 in res)
            {
                Console.WriteLine("\n" + s1);
            }
            Console.ReadKey();

        }

        private static void GetConcatOBJ()
        {
            StringConcat sc = new StringConcat
            {

                Firstname = Console.ReadLine(),
                Lastname = Console.ReadLine()

            };
            Console.WriteLine(sc.M2(sc.Firstname, sc.Lastname));
        }

        private static void StringJionObj()
        {
            StringIntoSingle obj1 = new StringIntoSingle();
            string[] input = { "chaitanya", "anil" };
            string res = obj1.M1(input);
            Console.WriteLine(res);
        }
    }
}
