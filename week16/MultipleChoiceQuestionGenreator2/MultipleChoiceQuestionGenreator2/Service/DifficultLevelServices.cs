using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MultipleChoiceQuestionGenreator2.Service
{
    public static class DifficultLevelServices
    {
        public static string AddData(int DifficultLevel, string Description, string Remarks)
        {
            using (SqlConnection conn = new SqlConnection(MssqlHelper.StrSqlConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    string sql = "INSERT INTO mcq_DifficultLevels (DifficultLevel, Description, Remarks) VALUES (@diffLevel, @description, @remark)";
                    cmd.CommandText = sql;

                    //add parameter with values.                    
                    cmd.Parameters.AddWithValue("@remark", Remarks);
                    cmd.Parameters.AddWithValue("@description", Description);
                    cmd.Parameters.AddWithValue("@diffLevel", DifficultLevel);

                    //Execute
                    cmd.ExecuteNonQuery();

                    return "Successfully Added.";
                }
            }
        }
    }
}
