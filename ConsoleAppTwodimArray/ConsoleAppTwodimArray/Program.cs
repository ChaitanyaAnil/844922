using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTwodimArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n;
            
            Console.WriteLine("enter row size");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("enter column size");
            n = int.Parse(Console.ReadLine());
        
            int[,] arr = new int[m, n];
            Console.WriteLine("enter matrix arry elements");
            for(int i=0;i<m; i++)
            {
                for(int j=0; j<n; j++)
                {
                    arr[i, j] =int.Parse( Console.ReadLine());
                }
            }

            Console.WriteLine("the matrix of 2d array is");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("  " + arr[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
