using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ConnectDBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionStringWithWindowAuth = "Server=CS;Database=DBSpring;IntegratedSecurity=True;";
            string connectionStringWithServerAuth = "Server=CS;Database=DBSpring;User Id=sa;Password=123456789cs";
            using (SqlConnection conn = new SqlConnection(connectionStringWithServerAuth))
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand("SELECT PersonID, Name, City FROM tbl_Persons", conn))
                {
                    using(SqlDataReader rd = cmd.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            int PersonID = rd.GetInt32(0);
                            string Name = rd.GetString(1);
                            string City = rd["City"].ToString();
                            Console.WriteLine("PersonID: " + PersonID + ", Name: " + Name + ", City: " + City);
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
