using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MultipleChoiceQuestionGenreator2.Service
{
    public static class StatusService
    {
        public static string AddData(string Description, string Remarks)
        {
            using (SqlConnection conn = new SqlConnection(MssqlHelper.StrSqlConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    string sql = "INSERT INTO mcq_Status (Remarks, Description) VALUES (@remark, @description)";
                    cmd.CommandText = sql;

                    //add parameter with values.
                    cmd.Parameters.AddWithValue("@remark", Remarks);
                    cmd.Parameters.AddWithValue("@description", Description);

                    //Execute
                    cmd.ExecuteNonQuery();

                    return "Successfully Added.";
                }
            }
        }
    }
}
