using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplicationDataOp
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                ADOlayer al = new ADOlayer();
                var rlist = al.GetallRecords();
                GridView1.DataSource = rlist;
                GridView1.DataBind();
            }
        }
    }
}