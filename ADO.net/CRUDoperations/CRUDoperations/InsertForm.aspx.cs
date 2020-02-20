using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace CRUDoperations
{
    public partial class InsertForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOlayer ad1 = new ADOlayer();
            int Rlic = Convert.ToInt32(TextBox1.Text);
            string Rname = TextBox2.Text;
            string Rloc = TextBox3.Text;
            string Rtype = TextBox4.Text;
           // ad1.DInsert(Rlic,Rname,Rloc,Rtype);
            string res = ad1.DInsert(Rlic,Rname,Rloc,Rtype);

            Label5.Text = res;
            var strlist = ad1.getallrecords();
            GridView1.DataSource = strlist;
            GridView1.DataBind();


        }
    }
}