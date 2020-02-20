using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
namespace TraineeApp
{
    public class TraineeAdoLayer
    {
        Trainee tr = new Trainee();
        DataSet ds = new DataSet();
        string constr = "";

        public TraineeAdoLayer()
        {
            constr = ConfigurationManager.ConnectionStrings["mystring"].ConnectionString;
        }
        public void Insert(Trainee tr)
        {
          
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_insert_tr",con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Tid", tr.Tid);
                    cmd.Parameters.AddWithValue("@Tname", tr.Tname);
                    cmd.Parameters.AddWithValue("@Tloc", tr.Tloc);
                    cmd.Parameters.AddWithValue("@Tdomain", tr.Tdomain);
                    cmd.Parameters.AddWithValue("@TstartDate", tr.TstartDate);
                  //  cmd.CommandText = "sp_insert_tr";

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = con;
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                    sda.Update(ds);

                }
                catch(Exception e)
                {
                    
                }
                
            }
           
          
        }
      
       public DataSet getallrecords()
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                string QuerySelect = "select * from Trainee";
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(QuerySelect, con);
                    SqlDataAdapter adp = new SqlDataAdapter(cmd);
                    adp.Fill(ds);
                }
                catch
                {

                }
                



            }


                return ds;
        }
        public void update(int id,string name)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_update_tr", con);
                cmd.Parameters.AddWithValue("@Tid", id);
                cmd.Parameters.AddWithValue("@Tname", name);
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(ds);
                

            }
        }
        public DataSet  Search(int id)
        {
            using (SqlConnection con = new SqlConnection(constr))
            {
                try
                {


                    con.Open();
                    SqlCommand cmd = new SqlCommand("sp_search_tr", con);
                    cmd.Parameters.AddWithValue("@Tid", id);

                    cmd.Connection = con;
                    cmd.CommandType = CommandType.StoredProcedure;
                    
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(ds);
                }
                catch
                {

                }
                return ds;

            }
        }

    }
}