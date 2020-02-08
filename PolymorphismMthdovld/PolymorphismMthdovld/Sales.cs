using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismMthdovld
{
    class Sales 
    {
        string productname;
        
        int quantity;
        double price;
        public static double totalsales = 0;
       public Sales()
        {

        }
        public  Sales(string pname,string id,double price)
        {
            ProductName = pname;
            Quantity= quantity;
            this.price = price;

        }
        
        
        public string ProductName
        {
            get { return productname; }
            set { productname = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set
            {
                quantity = value;
            }
        }
        public double Price
        {
           
            get => price;
            set
            {
                price = value;
            }
        }
        public double Saleamount
        {
            get { return price * quantity; }
        }
      public double TotalAmount
        {
            get { return totalsales +=Saleamount; }
        }
       
           
    }
}
