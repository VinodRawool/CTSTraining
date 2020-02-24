using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



namespace CRUDDemo 
{
    public class ADOLayer 
    {
        public string conStr = "";
       
        public ADOLayer() 
        {
            conStr = ConfigurationManager.ConnectionStrings["conString"].ConnectionString;
        }

        public string iStudent(int id, string name)
        {

            
            int i = 0;
            string exp = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand sq = new SqlCommand("IStudent", con);
                    sq.Parameters.AddWithValue("@Id", id);
                    sq.Parameters.AddWithValue("@Name", name);
                    sq.Connection = con;
                    sq.CommandType = CommandType.StoredProcedure;

                    //SqlDataAdapter sda = new SqlDataAdapter(sq);
                    //sda.Fill(ds);
                    //sda.Update(ds);

                    i = sq.ExecuteNonQuery();
                }
            }
            catch (Exception e) 
            {
                exp = e.ToString();
            }


            if (i > 0) { return i.ToString(); }
            else { return exp; }

        }


        public DataSet ShowStudent()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con=new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand sq = new SqlCommand("select * from Student", con);
                SqlDataAdapter sda = new SqlDataAdapter(sq);
                sda.Fill(ds);
                sda.Update(ds);
            }
                return ds;
        }

        public string uStudent(int id, string name)
        {


            int i = 0;
            string exp = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand sq = new SqlCommand("UStudent", con);
                    sq.Parameters.AddWithValue("@Id", id);
                    sq.Parameters.AddWithValue("@Name", name);
                    sq.Connection = con;
                    sq.CommandType = CommandType.StoredProcedure;

                    //SqlDataAdapter sda = new SqlDataAdapter(sq);
                    //sda.Fill(ds);
                    //sda.Update(ds);

                    i = sq.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                exp = e.ToString();
            }


            if (i > 0) { return i.ToString(); }
            else { return exp; }

        }

        public string dStudent(int id)
        {


            int i = 0;
            string exp = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand sq = new SqlCommand("delete from Student Where Id="+id, con);
                
                    //SqlDataAdapter sda = new SqlDataAdapter(sq);
                    //sda.Fill(ds);
                    //sda.Update(ds);

                    i = sq.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                exp = e.ToString();
            }


            if (i > 0) { return i.ToString(); }
            else { return exp; }

        }


        public string iFaculty(int id, string name)
        {


            int i = 0;
            string exp = "";
            try
            {
                using (SqlConnection con = new SqlConnection(conStr))
                {
                    con.Open();
                    SqlCommand sq = new SqlCommand("IFaculty", con);
                    sq.Parameters.AddWithValue("@Id", id);
                    sq.Parameters.AddWithValue("@Name", name);
                    sq.Connection = con;
                    sq.CommandType = CommandType.StoredProcedure;

                    //SqlDataAdapter sda = new SqlDataAdapter(sq);
                    //sda.Fill(ds);
                    //sda.Update(ds);

                    i = sq.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                exp = e.ToString();
            }


            if (i > 0) { return i.ToString(); }
            else { return exp; }

        }

        public DataSet ShowFaculty()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand sq = new SqlCommand("select * from Faculty", con);
                SqlDataAdapter sda = new SqlDataAdapter(sq);
                sda.Fill(ds);
                sda.Update(ds);
            }
            return ds;
        }

        public DataSet ShowCourse()
        {
            DataSet ds = new DataSet();
            using (SqlConnection con = new SqlConnection(conStr))
            {
                con.Open();
                SqlCommand sq = new SqlCommand("select * from Course", con);
                SqlDataAdapter sda = new SqlDataAdapter(sq);
                sda.Fill(ds);
                sda.Update(ds);
            }
            return ds;
        }





    }

}