using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArrayFunction
{
    class Program
    {
        public static double GetAvg(int[] marks)
        {
            int sum = 0;
            double avg;
            for (int i = 0; i < marks.Length; i++)
                sum += marks[i];
            avg = sum / marks.Length;
            return avg;

        }
        static void Main(string[] args)
        {
            
            int[] marks = new int[5];
            Console.WriteLine("enter marks");
            for(int i=0;i<marks.Length;i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
           var res= GetAvg(marks);
            Console.WriteLine("avg of marks is{0}", res);
            Console.ReadKey();
           
            
            
            }
            

        }
    }
