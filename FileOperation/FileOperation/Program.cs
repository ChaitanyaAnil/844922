using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileOperation
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#.net\FileOperation.txt";
            FileOper fo = new FileOper();
            int ch;
            do { 
            Console.WriteLine("enter your choice 1.create 2.displayfile 3.append text to file 4.delete 5.exit");
            ch = int.Parse(Console.ReadLine());
            
            


                switch (ch)
                {
                    case 1:
                        fo.CreateFile(path);
                        break;
                    case 2:
                        fo.Display(path);
                        break;
                    case 3:
                        fo.AddtoFile(path);
                        break;
                    case 4:
                        fo.DeleteFile(path);
                        break;
                    case 5:
                        return;
                    default:
                        Console.WriteLine("wrong choice entered!!!!!!! please enter choice btwn 1 to 4 only*****");
                        break;
                }
            } while (ch <= 4);
            Console.ReadKey();
        }
    }
}
