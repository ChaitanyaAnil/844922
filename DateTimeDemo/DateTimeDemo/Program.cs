using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "hello ";
            Console.WriteLine(s);
            string s1 = s.Insert(5, "world");
            Console.WriteLine(s1);
            string s2 = " welcome to C# .net";
            Console.WriteLine(s2);
            Console.WriteLine(String.Concat(s1,s2));
            string up = s1.ToUpper();
            string lo = up.ToLower();
            Console.WriteLine(up);
            Console.WriteLine(lo);
            Console.WriteLine(s1.Substring(3, 4));
            string[] names = new string[] { "anil", "prasad", "dp" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string st1 = "programing is started";
            string[] words = st1.Split();
            foreach(string a in words)
            {
                Console.WriteLine(a);
            }
            string nstr = string.Copy(st1);
            Console.WriteLine("copied string is{0}",nstr);
            int i = st1.IndexOf("og");
            Console.WriteLine("indes is{0}", i);
            int l = st1.Length;
            Console.WriteLine("length of string is{0}",l);
            words.Reverse();
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }
            int nx = string.Compare("hello", "hello");
            Console.WriteLine("comparsion is {0}", nx) ;
            Console.ReadKey();
        }
    }
}
