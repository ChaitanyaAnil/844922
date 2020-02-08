using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOResturant
{
    class RestaurentDataLayer
    {
        string constr = @"  Data Source = BLT1072\SQLEXPRESS; Initial Catalog = StudentDb; Integrated Security = True";
        /*  public RestaurentDataLayer()
          {
              constr = configurationManager.connectionStrings[""].connectionstring;
          }*/
          public void UpdateData(Restaurant rt)
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            con = new SqlConnection(constr);
            try
            {
                con.Open();

                // string QuerySelect = "select Rlic_no,Rname,Rloc,Rtype,Mtype,Mitem_name,Mitem_price from Restaurant full join Menu on Resturant.Rlic_no=Menu.Mid";
                string QuerySelect = "update Restaurant set Rloc = @data where Rlic_no= @id ";
                Console.WriteLine("enter resturant licence no to update details details");
                int pvalue = int.Parse(Console.ReadLine());
                Console.WriteLine("enter thr loc");
                string invalue = Console.ReadLine();

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@data", invalue);
                cmd.Parameters.AddWithValue("@id", pvalue);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //  Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
          public void DeleteData(Restaurant rt)
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            con = new SqlConnection(constr);
            try
            {
                con.Open();

                // string QuerySelect = "select Rlic_no,Rname,Rloc,Rtype,Mtype,Mitem_name,Mitem_price from Restaurant full join Menu on Resturant.Rlic_no=Menu.Mid";
                string QuerySelect = "delete  from Restaurant where Rlic_no= @id ";
                Console.WriteLine("enter resturant licence no to delete details");
                int pvalue = int.Parse(Console.ReadLine());

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@id", pvalue);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //  Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
          public void SearchData(Restaurant rt)
        {

            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            con = new SqlConnection(constr);
            try
            {
                con.Open();

                // string QuerySelect = "select Rlic_no,Rname,Rloc,Rtype,Mtype,Mitem_name,Mitem_price from Restaurant full join Menu on Resturant.Rlic_no=Menu.Mid";
                string QuerySelect = "select * from Restaurant where Rlic_no= @id ";
                Console.WriteLine("enter resturant licence no to get details");
                int pvalue = int.Parse(Console.ReadLine());

                cmd = new SqlCommand(QuerySelect, con);
                cmd.Parameters.AddWithValue("@id", pvalue);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //  Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2], reader[3], reader[4]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }
        }
          public void InsertRestaurent(Restaurant rt)
        {
            string insertQuery = string.Format("insert into Restaurant(Rlic_no,Rname,Rloc,Rtype) values('{0}','{1}','{2}','{3}')",rt.Rlic_no,rt.Rname,rt.Rloc,rt.Rtype);
            using (SqlConnection con = new SqlConnection(constr))
            {
                int i = 0;
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(insertQuery, con);
                    i = cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);

                }
                if (i > 0)

                    Console.WriteLine(" {0} rows inserted", i);
            }
            
        }
        public void ShowData(Restaurant rt)
        {
           

           
            string constr = @"  Data Source = BLT1072\SQLEXPRESS; Initial Catalog = StudentDb; Integrated Security = True";
            SqlConnection con = null;
            SqlCommand cmd = null;
            SqlDataReader reader = null;

            con = new SqlConnection(constr);
            try
            {
                con.Open();

                // string QuerySelect = "select Rlic_no,Rname,Rloc,Rtype,Mtype,Mitem_name,Mitem_price from Restaurant full join Menu on Resturant.Rlic_no=Menu.Mid";
                string QuerySelect = "select * from Restaurant";

                cmd = new SqlCommand(QuerySelect, con);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //  Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", reader[0], reader[1], reader[2], reader[3], reader[4], reader[5], reader[6]);
                    Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", reader[0], reader[1], reader[2], reader[3],reader[4]);
                }


            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                con.Close();
            }

        }
       
    }
}
