using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayListObj();
            // HashtableObj();
            // StackObj();
            // QueueObj();
            SortedListObj();
            Console.ReadKey();
        }

        private static void SortedListObj()
        {
            SortedList sl = new SortedList();
            sl.Add("anil", 1234);
            sl.Add("dp", 234);
            sl.Add("prasad", 342);
            foreach (string d in sl.Keys)
            {
                Console.WriteLine(d);
            }
            foreach (int v in sl.Values)
            {
                Console.WriteLine(v);
            }
        }

        private static void QueueObj()
        {
            Queue q = new Queue();
            q.Enqueue("anil");
            q.Enqueue("dp");
            q.Enqueue("prasd");
            foreach (string d in q)
            {
                Console.WriteLine(d);
            }
            Console.WriteLine();
            q.Dequeue();
            foreach (string d in q)
            {
                Console.WriteLine(d);
            }
        }

        private static void StackObj()
        {
            Stack s = new Stack();
            s.Push("123");
            s.Push("anil");
            s.Push("c#");
            foreach (string d in s)
            {
                Console.WriteLine(d);
            }
            s.Pop();
            foreach (string d in s)
            {
                Console.WriteLine(d);
            }
        }

        private static void HashtableObj()
        {
            Hashtable hst = new Hashtable();
            hst.Add("raju", "1234");
            hst.Add("vimala", "5678");
            hst.Add("kiran", "76552");
            foreach (string k in hst.Keys)
            {

                Console.WriteLine(k);
            }

            foreach (string h in hst.Values)
            {

                Console.WriteLine(h);
            }
            Console.WriteLine();
            hst.Remove("kiran");

            foreach (string h in hst.Values)
            {

                Console.WriteLine(h);
            }
        }

        private static void ArrayListObj()
        {
            ArrayList al = new ArrayList() { "dp", "prasad", "vishnu", "momu", "rohit" };
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Add("anil");
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Sort();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Insert(2, "dillep");
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            string[] r = new string[] { "car", "bike" };
            al.SetRange(2, r);
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
            al.Reverse();
            foreach (string a in al)
            {
                Console.WriteLine(a);
            }
        }
    }
}
