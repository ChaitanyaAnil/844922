using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActPredicateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // MethodPredicate();
            ListDemoMethod();

            Console.ReadKey();
        }

        private static void ListDemoMethod()
        {
            Console.WriteLine("using ListDemo");
            List<Student> lst = new List<Student>
            {
                new Student{Id=1,Sname="anil",Course="c#"},
                 new Student{Id=3,Sname="dp",Course="c#"},
                  new Student{Id=4,Sname="prasad",Course="c#"},
                   new Student{Id=2,Sname="vishnu",Course="c#"}



            };
            Console.WriteLine("emloyee details are :");
            foreach (var s1 in lst)
            {
                Console.WriteLine("{0} \t {1}\t{2}", s1.Id, s1.Sname, s1.Course);
            }
            List<Student> s = ListDemo(lst);

            Console.WriteLine("after sorting emloyee details are :");
            foreach (Student s1 in lst)
            {
                Console.WriteLine("{0} \t {1}\t{2}", s1.Id, s1.Sname, s1.Course);
            }
        }

        private static List<Student>ListDemo(List<Student> lst)
        {
            lst.Sort((x, y) => x.Id.CompareTo(y.Id));
            return lst;
        }

        private static void MethodPredicate()
        {
            Action<int, int> Multiply = (x, y) => Console.WriteLine("{0}", x * y);
            Func<int, int, double> ad = (x, y) => x + y;
            /*
                        Console.WriteLine("enter student details \n enter student id");
                        int id = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter student name");
                        string name = Console.ReadLine();
                        Console.WriteLine("enter cousre");
                        string Course = Console.ReadLine();*/

            List<Student> lst = new List<Student>
            {
                new Student{Id=1,Sname="anil",Course="c#"},
                 new Student{Id=3,Sname="dp",Course="c#"},
                  new Student{Id=4,Sname="prasad",Course="c#"},
                   new Student{Id=2,Sname="vishnu",Course="c#"}



            };

            Console.WriteLine("emloyee details are :");
            foreach (var s in lst)
            {
                Console.WriteLine("{0} \t {1}\t{2}", s.Id, s.Sname, s.Course);
            }
            lst.Sort((a, b) => a.Id.CompareTo(b.Id));

            Console.WriteLine("after sorting emloyee details are :");
            foreach (Student s in lst)
            {
                Console.WriteLine("{0} \t {1}\t{2}", s.Id, s.Sname, s.Course);
            }
            Console.WriteLine("enter  student id to predticate");
            int n = int.Parse(Console.ReadLine());
            Predicate<Student> fst = x => x.Id == n;
            var st = lst.Find(fst);
            /*foreach(var  s in st)
            {
                Console.WriteLine("{0} \t {1}\t{2}", st.Id, st.Sname, st.Course);
            }*/
            Console.WriteLine("student Id: {0} \t student Name : {1} \t Student Course:{2}", st.Id, st.Sname, st.Course);
        }
    }
}
