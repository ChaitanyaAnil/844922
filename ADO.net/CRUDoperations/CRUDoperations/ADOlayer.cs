using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace CRUDoperations
{
    public class ADOlayer
    {
        DataSet ds = new DataSet();
        string constr = "";
        public ADOlayer()
        {
            constr = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        }
        public DataSet getallrecords()
        {
            // DataSet ds = new DataSet();

            string query = "select * from Restaurant";



            try
            {
                using (SqlConnection con = new SqlConnection(constr))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlDataAdapter ada = new SqlDataAdapter(cmd);
                    ada.Fill(ds);


                }
            }
            catch (Exception e)
            {
            }
            return ds;

        }
        public string DInsert(int Rlic, string Rname, string Rloc, string Rtype)
        {
            string s = "";
            int i = 0;
            //DataSet ds = new DataSet();
          //  string constr =@"Data Source = BLT1072\SQLEXPRESS; Initial Catalog = StudentDb; Integrated Security = True";
            using (SqlConnection con = new SqlConnection(constr))
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    con.Open();
                    cmd = new SqlCommand("sp_insert2", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Rlic", Rlic);
                    cmd.Parameters.AddWithValue("@Rname", Rname);
                    cmd.Parameters.AddWithValue("@Rloc", Rloc);
                    cmd.Parameters.AddWithValue("@Rtype", Rtype);
                    cmd.CommandText = "insertRes";
                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                   i= cmd.ExecuteNonQuery();

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);
                }
                catch (Exception e)
                { }
                if(i>0)
                {
                   s= string.Format("inserted succes");
                }
                return s;
            }

        }
    }
}