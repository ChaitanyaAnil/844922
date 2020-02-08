using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArray2d
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            Console.WriteLine("enter m size");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter m size");
            n = int.Parse(Console.ReadLine());
            int[,] arr1 = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr1[i, j] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
            }
            int[,] arr2 = new int[m, n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr2[i, j] = int.Parse(Console.ReadLine());

                }
                Console.WriteLine();
            }
            //diplsy the arry elements
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " +arr1[i, j]);

                }
                Console.WriteLine();
            }
            
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" "+arr2[i, j]); ;

                }
                Console.WriteLine();
            }
        
          

            int[,] arr3 = new int[m, n];
            for(int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr3[i, j] = arr1[i, j] + arr2[i, j];

                }
            }

            Console.WriteLine("the new array is");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(" " +arr3[i, j]);

                }
     Console.WriteLine();
               
            }
            Console.ReadKey();
        }
            
    }
}
