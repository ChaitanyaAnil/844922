using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHandsonTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int ch;
            EmpColection e1 = new EmpColection();
            Console.WriteLine("1.add\n2.remove\n3.show\n");
            ch = int.Parse(Console.ReadLine());
            switch(ch)
            {
                case 1:

                    Console.WriteLine("enter how many employes to add");
                    int no = int.Parse(Console.ReadLine());
                    for (int i = 0; i < no; i++)
                    {
                        /* e1.Add(123, "anil", "program Analyst", 22000.00);
                         e1.Add(223, "dp", "program Analyst", 22000.00);
                         e1.Add(323, "prasad", "program Analyst", 22000.00);
                         e1.Add(423, "sreshanth", "program Analyst", 22000.00);

                        Console.WriteLine("enter employee data");
                        int id = int.Parse(Console.ReadLine());
                        string name = Console.ReadLine();
                        string desg = Console.ReadLine();
                        double sal = double.Parse(Console.ReadLine());
                        e1.Add(id, name, desg, sal);
                        e1.Add(id, name, desg, sal);*/
                        e1.Add();
                        
                    }
                    break;
                    
                case 2:
                    Console.WriteLine("enter index to rmove");
                    int ind = int.Parse(Console.ReadLine());
                    e1.Remove(ind);
                    break;
                case 3: e1.Show();
                    break;
                default:Console.WriteLine("wrong choice entered****");
                    break;
                    
            }
          /* 
            Console.WriteLine("enter how many employes to add");
            int no = int.Parse(Console.ReadLine());
            for (int i = 0; i < no; i++)
            {
                /* e1.Add(123, "anil", "program Analyst", 22000.00);
                 e1.Add(223, "dp", "program Analyst", 22000.00);
                 e1.Add(323, "prasad", "program Analyst", 22000.00);
                 e1.Add(423, "sreshanth", "program Analyst", 22000.00);

                Console.WriteLine("enter employee data");
                int id = int.Parse(Console.ReadLine());
                string name = Console.ReadLine();
                string desg = Console.ReadLine();
                double sal = double.Parse(Console.ReadLine());
                e1.Add(id, name, desg, sal);
                e1.Add(id, name, desg, sal);
                e1.Add();
            }
            e1.Show();
            Console.WriteLine("enter index to rmove");
            int ind = int.Parse(Console.ReadLine());
            e1.Remove(ind);
            Console.WriteLine("after removin the elemts are\n");
            e1.Show();*/
            Console.ReadKey();
            
            
        }
    }
}
