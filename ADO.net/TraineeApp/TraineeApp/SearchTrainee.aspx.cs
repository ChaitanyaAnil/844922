using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TraineeApp
{
    public partial class SearchTrainee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TraineeAdoLayer tl = new TraineeAdoLayer();
            int id = int.Parse(TextBox1.Text);
         var list1=  tl.Search(id);
            GridView1.DataSource = list1;
            GridView1.DataBind();
           
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }
    }
}