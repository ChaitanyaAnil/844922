using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplicationDataOp
{
    public partial class InsertForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }
        string constr = "";
        public InsertForm()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public void Button1_click(object sender, EventArgs e)
        {
           
            
            using (SqlConnection con = new SqlConnection(constr))
            {
                int i = 0;
                try
                {

                    SqlCommand cmd = new SqlCommand("sp_insert", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rlic", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Rname", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@Rloc", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@Rtpe", TextBox4.Text);
                    con.Open();

                    i = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                }
                if (i > 0)

                    Console.WriteLine(" {0} rows inserted", i);
            }
        }   }
}