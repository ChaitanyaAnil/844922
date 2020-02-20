using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class EnterData : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            TraineeAdoLayer tal = new TraineeAdoLayer();
            Trainee tr = new Trainee
            {
                Tid = Convert.ToInt32(TextBox1.Text),
                Tname = TextBox2.Text,
                Tloc = TextBox3.Text,
                Tdomain = TextBox4.Text,
                TstartDate = DateTime.Parse((TextBox5.Text))


            };

            tal.Insert(tr);

        }
    }
}