using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADOExample
{
    class Program
    {
        static void Main(string[] args)
        {

            SqlConnection con = null;
            try
            {
                con = new SqlConnection(@"Data Source=BLT1047\SQLEXPRESS2014;Initial Catalog=School;Integrated Security=True");

                //SqlCommand cm = new SqlCommand("create table studentTest(id int not null,name varchar(100), email varchar(50), join_date date)", con);
                SqlCommand cm1 = new SqlCommand("select * from Student",con);
                con.Open();
                
                SqlDataReader sd= cm1.ExecuteReader();
             
                while (sd.Read())
                {
                    Console.WriteLine(sd[0]+" "+sd[1] +" "+ sd[2]);
                }

              //  Console.WriteLine("Table created Successfully");
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." + e);
            }
            finally
            {
                con.Close();
            }

            Console.ReadKey();

        }

    }
}
