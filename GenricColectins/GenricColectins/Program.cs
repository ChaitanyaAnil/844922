using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenricColectins
{
    class Program
    {
        static void Main(string[] args)
        {
            // GenricListObjMethod();
            //GenricHashSetObjMethod();
            // GenericStack();
            //GenericQueue();
            //DictionaryGeneric();
            SortedDictionary<int, Course> sortDt = new SortedDictionary<int, Course>();
            // sortDt.Add(1, "chennai");
            // sortDt.Add(2, "hyderabad");
            //sortDt.Add(3, "vijayawda");
            GenericSortDict(sortDt);

            Console.ReadKey();
        }

        private static void GenericSortDict(SortedDictionary<int, Course> sortDt)
        {
            Course c = new Course
            {
                Cid = 223,
                Cname = "aws",
                StartDate = DateTime.Today,
                Fees = 600000
            };
            Course c1 = new Course
            {
                Cid = 131,
                Cname = "big data",
                StartDate = DateTime.Today,
                Fees = 600000
            };
            sortDt.Add(1, c);
            sortDt.Add(2, c1);


            foreach (KeyValuePair<int, Course> sd in sortDt)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", sd.Key, sd.Value.Cid, sd.Value.Cname, sd.Value.StartDate, sd.Value.Fees);
            }
        }

        private static void DictionaryGeneric()
        {
            Dictionary<int, Course> dcr = new Dictionary<int, Course>();
            dcr.Add(1, new Course
            {
                Cid = 1,
                Cname = "aws",
                StartDate = DateTime.Today,
                Fees = 600000

            });
            foreach (KeyValuePair<int, Course> dc in dcr)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", dc.Key, dc.Value.Cid, dc.Value.Cname, dc.Value.StartDate, dc.Value.Fees);
            }
        }

        private static void GenericQueue()
        {
            Queue<Course> q = new Queue<Course>();
            q.Enqueue(new Course
            {
                Cid = 1,
                Cname = "aws",
                StartDate = DateTime.Today,
                Fees = 600000
            });
            q.Enqueue(new Course
            {
                Cid = 2,
                Cname = "devops",
                StartDate = DateTime.Today,
                Fees = 500000
            });
            q.Enqueue(new Course
            {
                Cid = 1,
                Cname = "azure",
                StartDate = DateTime.Today,
                Fees = 400000
            });
            foreach (Course cr in q)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }

        private static void GenericStack()
        {
            Stack<Course> s = new Stack<Course>();

            s.Push(new Course
            {
                Cid = 1,
                Cname = "Visual basic",
                StartDate = DateTime.Today,
                Fees = 600000
            });
            s.Push(new Course
            {
                Cid = 2,
                Cname = ".net",
                StartDate = DateTime.Today,
                Fees = 500000
            });
            s.Push(new Course
            {
                Cid = 1,
                Cname = "mainframes",
                StartDate = DateTime.Today,
                Fees = 400000
            });
            foreach (Course cr in s)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }

        private static void GenricHashSetObjMethod()
        {
            Course c = new Course
            {
                Cid = 1,
                Cname = "Javascript",
                StartDate = DateTime.Today,
                Fees = 600000


            };
            HashSet<Course> hs = new HashSet<Course>();
            hs.Add(c);
            hs.Add(new Course
            {
                Cid = 2,
                Cname = "Artificial inteligance",
                StartDate = Convert.ToDateTime("08-03-2020"),
                Fees = 500000

            });
            hs.Add(new Course
            {
                Cid = 3,
                Cname = "Big data",
                StartDate = Convert.ToDateTime("06-03-2020"),
                Fees = 500000

            });
            foreach (Course cr in hs)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }
        private static void GenricListObjMethod()
        {
            Course c = new Course
            {
                Cid = 1,
                Cname = "c#",
                StartDate = DateTime.Today,
                Fees = 600000


            };
            List<Course> Courselist = new List<Course>();
            Courselist.Add(c);
            Courselist.Add(new Course
            {
                Cid = 2,
                Cname = "java",
                StartDate = Convert.ToDateTime("08-03-2020"),
                Fees = 500000

            });
            Courselist.Add(new Course
            {
                Cid = 3,
                Cname = "php",
                StartDate = Convert.ToDateTime("06-03-2020"),
                Fees = 500000

            });
            foreach (Course cr in Courselist)
            {
                Console.WriteLine("{0}\n{1}\n{2}\n{3}", cr.Cid, cr.Cname, cr.StartDate, cr.Fees);
            }
        }

    }
}
