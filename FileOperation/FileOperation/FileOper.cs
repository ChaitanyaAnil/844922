using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FileOperation
{
    class FileOper
    {
        string path = @"D:\c#.net\FileOperation.txt";
        public void CreateFile(string path)
        {
            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    Console.WriteLine("enter your name");
                    string name = Console.ReadLine();
                    Console.WriteLine("enter your id");
                    string id = Console.ReadLine();
                    Console.WriteLine("enter your city");
                    string city = Console.ReadLine();
                    sw.WriteLine("name is:" + name);
                    sw.WriteLine("id is:" + id);
                    sw.WriteLine("city is:" + city);
                }
            }
        }
        public void Display(string path)
        {


            using (StreamReader sr = File.OpenText(path))
            {
                
                Console.WriteLine("details are:");
                string s;
                while((s=sr.ReadLine())!=null)
                {
                    Console.WriteLine(" "+s);
                }
            }
        }
        public void AddtoFile(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("\n enter text to  add to file");
                string s = Console.ReadLine();
                sw.WriteLine(s);

            }
        }
        public void DeleteFile(string path)
        {
            File.Delete(path);
            Console.WriteLine("file is deleted");
        }


        
    }
}
