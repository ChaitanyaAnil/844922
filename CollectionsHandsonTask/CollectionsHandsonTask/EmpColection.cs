using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHandsonTask
{
    class EmpColection
    {
        List<Employee> lstEmp = new List<Employee>();
        public void Add()
        {
            Console.WriteLine("enter employee data");
            int id = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            string desg = Console.ReadLine();
            double sal = double.Parse(Console.ReadLine());
            lstEmp.Add(new Employee {
            Eid=id,
            Ename=name,
            Designation=desg,
            Salary=sal});
        }
        /*  Employee e = new Employee
   {
       Eid = 1234,
       Ename = "anil",
       Designation = "programer Analyst",
       Salary = 22000.00
   };
   Employee e2 = new Employee
   {
       Eid = 2344,
       Ename = "dp",
       Designation = "programer Analyst",
       Salary = 22000.00
   };
   public void Add()
   {
       lstEmp.Add(e);
       lstEmp.Add(e2);



   }*/
        

        public void Show()
        {
            foreach (Employee ed in lstEmp)
            {
                Console.WriteLine("id:{0}\t Name :{1}\t Desgignation : {2}\t salary : {3}", ed.Eid, ed.Ename, ed.Designation, ed.Salary);
            }
        }
        public void Remove(int ind)
        { 
            lstEmp.RemoveAt(ind);
        }
    }
}
