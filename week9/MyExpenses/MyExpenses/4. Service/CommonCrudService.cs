using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace MyExpenses.Service
{
    public static class CommonCrudService
    {
        public static DataTable ReadAllData(string SelectSql)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SelectSql, conn);
                DataSet dataSet = new DataSet();
                dataAdapter.Fill(dataSet);
                return dataSet.Tables[0];
            }
        }

        public static string MakeTransaction(List<string> listTransactionSqls)
        {
            using (SqlConnection conn = new SqlConnection(MssqlDBHelper.ConnectionString))
            {
                conn.Open();
                SqlTransaction sqlTrx = conn.BeginTransaction();
                try
                {
                    foreach (var sql in listTransactionSqls)
                    {
                        SqlCommand cmd = new SqlCommand(sql, conn, sqlTrx);
                        cmd.ExecuteNonQuery();
                    }
                    sqlTrx.Commit();
                    return "Successfully Transmitted.";
                }
                catch (Exception ex)
                {
                    sqlTrx.Rollback();
                    return ex.ToString();
                }      
            }
        }
    }
}
