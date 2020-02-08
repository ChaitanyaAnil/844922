using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring array with size and intilize element after
            int[] marks = new int[6];
            marks[0] = 85;
            marks[1] = 89;
            Console.WriteLine("array elements are {0} and {1}", marks[0], marks[1]);
            //declaring elemnt within instaniation of arry 
            int[] mks = new int[] { 75, 96, 65, 85, 65 };
            for(int i=0;i<mks.Length;i++)
            {
                Console.WriteLine("subject marks are {0}", mks[i]);
            }
            // declaring string with in arrys
            string[] subject = new string[3] { "english", "maths", "science" };
            Console.WriteLine("the subjects are{0} {1} {2}", subject[0], subject[1], subject[2]);

            
            Console.ReadKey();
        }
    }
}
