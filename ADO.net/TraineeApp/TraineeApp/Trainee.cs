using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TraineeApp
{
    public class Trainee
    {
        public int Tid { get; set; }
        public string Tname { get; set; }
        public string Tloc { get; set; }
        public string Tdomain { get; set; }
        public DateTime TstartDate { get; set; }
    }
}