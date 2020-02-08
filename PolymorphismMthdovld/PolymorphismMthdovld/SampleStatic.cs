using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismMthdovld
{
    class SampleStatic
    {
        int no;
        static int count = 0;
        public SampleStatic()
        {
           
                no++;
                count++;

                Console.WriteLine("no:{0}\ncount:{1}", no, count);
            
        }
        public static void show()
        {
            count++;
            Console.WriteLine("form static show method" + "the count is {0}", count);
        }
    }
}
