using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloading
{
    struct Demo
    {
        int no1, no2;
       
        
      
        public Demo(int x,int y)
        {
            no1 = x;
            no2 = y;

        }
        public void ShowData()
        {
            Console.WriteLine(no1 + " " + no2);
        }

       

        public static Demo operator +(Demo a,Demo b)
        {
            Demo t = new Demo();
            t.no1 = a.no1 + b.no1;
            t.no2 = a.no2+b.no2;
            return t;

        }
      

        
    }
}
