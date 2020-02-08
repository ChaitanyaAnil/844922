using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo
{
    class Trainee
    {
        //data fields
        string name, id, addrs;//instance variables
        int age;
        public void GetData(string nm,string id,string adr,int ag)
        {
            name = nm;
            this.id = id;
            addrs = adr;
            age = ag;

        }
        public void ShowData()
        {
            Console.WriteLine(name);
            Console.WriteLine(id+" "+addrs);
            Console.WriteLine(age);
        }
       
    }
}
