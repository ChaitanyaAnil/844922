using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibCalculation
{
    public class Calculation
    {
        public int No1 { get; set; }
        public int No2
        {
            get;
            set;
        }
        public String Add()
        {
            return String.Format("sum = {0}", No1 + No2);
        }
        public String Diff()
        {
            return string.Format("difference = {0}", No1 - No2);
        }
        public string Multiply()
        {
            return string.Format("multiplication = {0}", No1 * No2);
        }
        public string Divison()
        {
            return string.Format("quitient ={0}", No1 / No2);
        }
    }
}
