using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class UpdataForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TraineeAdoLayer tl = new TraineeAdoLayer();
            int Tid = int.Parse(TextBox1.Text);
            string Tname = TextBox2.Text;
            tl.update(Tid, Tname);
        }
    }
}