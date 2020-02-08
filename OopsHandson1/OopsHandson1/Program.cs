using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsHandson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Exam e = new Exam();
            Exam e1 = new Exam();
            e.GetDetails("anil", "Emp922", 80,70,60,80);
            e1.GetDetails("prasad", "EMP456", 75,80,97,56);

            e.ShowDetails();
            e1.ShowDetails();

            Console.ReadKey();
        }
    }
}
