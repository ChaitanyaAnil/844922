using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FilesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"D:\c#.net\First.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("enter some text here...");
                string text = Console.ReadLine();
                sw.WriteLine("after appended " + text);
            }
                CreateFile(path);
            ReadtheExistFileToDisplay(path);

            Console.ReadKey();
        }

        private static void ReadtheExistFileToDisplay(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }

            }
        }

        private static void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                //create a file 
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter city");
                    string city = Console.ReadLine();
                    Console.WriteLine("enter id");
                    int id = int.Parse(Console.ReadLine());
                    sw.WriteLine("name:" + name);
                    sw.WriteLine("city :" + city);
                    sw.WriteLine("id :" + id);
                }
            }
        }
    }
}
