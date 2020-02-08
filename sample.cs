using System;
namespace basicApp
{
    public class sample
      {
        public static void Main(string [] args)
	    {
            int age;
            string ename;
            Console.WriteLine("enter your name");
            ename = Console.ReadLine();
            Console.WriteLine("enter your age");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("congraulations mr/mrs {0} on your {1} birthday",ename,age);
            Console.ReadKey();

           }
      }
}