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
            Console.WriteLine("Before Add");
            ReadDataFromDBSpring("SELECT PersonID, Name, City FROM tbl_Persons");

            //AddDataToDBSpring("INSERT INTO tbl_Persons Values(5, 'Mying Mg', 'Lin Lin', 'Yangon');");

            //Console.WriteLine("After Added");
            //ReadDataFromDBSpring("SELECT PersonID, Name, City FROM tbl_Persons");

            //Console.WriteLine("Test Update Query");
            UpdateDataToDBSpring("UPDATE tbl_Persons SET FatherName='U Shwe' WHERE PersonID=1;");

            Console.WriteLine("Test Delete Query");
            UpdateDataToDBSpring("DELETE FROM tbl_Persons WHERE PersonID=3;");

            Console.WriteLine("After deleted");
            ReadDataFromDBSpring("SELECT PersonID, Name, City FROM tbl_Persons");

            Console.ReadLine();
        }

        private static void AddDataToDBSpring(string insertQuery)
        {
            string connectionStringWithServerAuth = "Server=.; Database=DBSpring; user id=sa; password=123456789cs";
            using (SqlConnection conn = new SqlConnection(connectionStringWithServerAuth))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand(insertQuery, conn);

                int insertNo = cmd.ExecuteNonQuery();
                if (insertNo > 0)
                {
                    Console.WriteLine("Successfully inserted.");
                }
            }
        }

        private static void ReadDataFromDBSpring(string selectQuery)
        {
            string connectionStringWithServerAuth = "Server=.; Database=DBSpring; user id=sa; password=123456789cs";
            using (SqlConnection conn = new SqlConnection(connectionStringWithServerAuth))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                {
                    using (SqlDataReader rd = cmd.ExecuteReader())
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
        }

        private static void UpdateDataToDBSpring(string updateQuery)
        {
            string connectionString = "Server=localhost; Database=DBSpring; User ID=sa; password=123456789cs;";
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {                
                conn.Open();
                SqlCommand cmd = new SqlCommand(updateQuery, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
                
            }
            finally{
                conn.Close();
            }

            //string connectionString = "Server=localhost; Database=DBSpring; User ID=sa; password=123456789cs;";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();

            //    SqlCommand cmd = new SqlCommand(updateQuery, conn);
            //    cmd.ExecuteNonQuery();
            //}

        }
    }

    
}
