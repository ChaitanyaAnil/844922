using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CRUDoperations
{
    public partial class FormDisplay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ADOlayer a = new ADOlayer();
                var strlist = a.getallrecords();
                GridView1.DataSource = strlist;
                GridView1.DataBind();

               
                




            }

        }
    }
}