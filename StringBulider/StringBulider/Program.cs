using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBulider
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder("hello");
            Console.WriteLine(stb);

            stb.Append(23445);
            Console.WriteLine("appended long values {0}",stb);
            int i = stb.Capacity;
            Console.WriteLine("intial capaciy of strin builder is{0}",i);
            stb.Insert(6, "World");
            Console.WriteLine("inserted at 6 is{0}", stb);
            stb.Remove(7, 4);
            Console.WriteLine("after removing {0}", stb);
            stb.Replace("lo", "arious");
            Console.WriteLine("After replacing {o}", stb);
            
        }
    }
}
