using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsDemo1Constructor
{
    class Car
    {
        string regno, color, model;
        int price;
        public Car()   //default constructor with no arguents
        {
            Console.WriteLine("no arg-consructor");
        }
        public Car(int price)
        {
            this.price = price;
            Console.WriteLine("int 1  arg-consructor");
        }
        public Car(string regno,string col,string mod,int price)
        {
            this.regno = regno;
            color = col;
            model = mod;
            this.price = price;
            Console.WriteLine("four arg-consructor");

        }
        /*
        public void ShowCar()
        {
            Console.WriteLine(regno);
            Console.WriteLine(color);
            Console.WriteLine(model);
            Console.WriteLine(price);

        }*/
        public string ShowCar()
        {
            return string.Format("reg no is{0}\n model is{1}\n color is {2}\n price is {3} ", regno, color, model, price);
        }
    }
}
