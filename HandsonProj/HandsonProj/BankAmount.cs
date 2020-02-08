using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsonProj
{
    class BankAmount
    {
       
        

        public int Accno
        {
            get;
            set;
        }
        public double Balance
        {
            get;
            set;
        }
        
        public Customer c
        {
            get;
            set;
        }
        public void ShowDetails()
        {
            Console.WriteLine("customer id :{0}\n Name :{1}\n Adress:{2}\n\account Number:{3}\nbalence:{4}" , c.Cid , c.Name ,c.Address , Accno , Balance);
        }
        public  virtual double IntrestAmout(double Balance)
        {
            double Rate = 2;
            double Years = 2;
            double cal = (Balance * Rate * Years) / 100;
            Console.WriteLine("intrest amount:{0}" , cal);
            return cal;
        }
        

        
    }
}
