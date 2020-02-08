using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace WebApplicationDataOp
{
    public class ADOlayer
    {
        string constr = "";
        public ADOlayer()
        {
            constr = ConfigurationManager.ConnectionStrings["myconstring"].ConnectionString;
        }
        public DataSet GetallRecords()
        {
            DataSet ds = new DataSet();


            string SelectQuery = "select * from Restaurant";
            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(SelectQuery, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);
                }

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return ds;
        }
    }
}