using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsHandson1
{
    class Exam
    {
        //variables
        String StudName,StdId;
        int mark1, mark2, mark3, mark4;
        int res;
        public void GetDetails(string StudName,string StdId,int mark1,int mark2,int mark3,int mark4)
        {
            this.StudName = StudName;
            this.StdId = StdId;
            this.mark1 = mark1;
            this.mark2 = mark2;
            this.mark3 = mark3;
            this.mark4 = mark4;
            res = mark1 + mark2 + mark3 + mark4 / 4;
            
        }
        public void ShowDetails()
        {
            Console.WriteLine(StudName);
            Console.WriteLine(StdId);
            Console.WriteLine(mark1);
            Console.WriteLine(mark2);
            Console.WriteLine(mark3);
            Console.WriteLine(mark4);
            //Console.WriteLine(res);
            if (res < 70)
            {
                Console.WriteLine("1st class");

            }
            else
            {
                Console.WriteLine("distinction");
            }

        }
       /* public void result()
        {
            if(marks<70)
            {
                Console.WriteLine("1st class");

            }
            else
            {
                Console.WriteLine("distinction");
            }
        }*/
    }
}
