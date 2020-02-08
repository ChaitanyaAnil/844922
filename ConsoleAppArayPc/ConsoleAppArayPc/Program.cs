using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppArayPc
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i;
            
            Console.WriteLine("enter no of array elemnts");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for ( i=0;i<n;i++)
            {
               arr[i] = int.Parse(Console.ReadLine());
            }

            while(i<arr.Length)
            {
                if(arr[i]==0)
                {
                    arr1[i] = arr[i];
                }
            }
        }
    }
}
