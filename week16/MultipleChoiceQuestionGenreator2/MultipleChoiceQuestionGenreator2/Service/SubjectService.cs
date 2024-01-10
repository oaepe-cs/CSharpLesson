using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace MultipleChoiceQuestionGenreator2.Service
{
    public static class SubjectService
    {        
        public static string AddSubject(string Name, string Description)
        {
            using (SqlConnection conn = new SqlConnection(MssqlHelper.StrSqlConnection))
            {
                conn.Open();
                string sql = "INSERT INTO mcq_Subjects (Name, Description) VALUES (@name, @description)";
                using(SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@name", Name);
                    cmd.Parameters.AddWithValue("@description", Description);

                    cmd.ExecuteNonQuery();
                    return "Successfully Added!";
                }
            }
        }
    }
}
