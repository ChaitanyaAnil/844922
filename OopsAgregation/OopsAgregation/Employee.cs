using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAgregation
{
    class Employee
    {
        int id;
        String name, address;
        public Department department;
        public Employee(int id,string name,string address,Department department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.department = department;
        }
        public void Display()
        {
            Console.WriteLine(id + " " + name + " " + address + " " + department.deptname + " " +department.depid);
        }
    }
}
