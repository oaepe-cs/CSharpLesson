using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace MultipleChoiceQuestionGenreator2
{
    public class MssqlHelper
    {
        public static string StrSqlConnection = "Server=.; Database=MultipleChoicesQuestionGenerator; User Id=sa; Password=123456789cs";

        public static void ReadData(DataGridView dgv, string selectSql)
        {
            using (SqlConnection conn = new SqlConnection(StrSqlConnection))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(selectSql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                DataTable result = ds.Tables[0];
                dgv.DataSource = result;
            }
        }

        public static void BindCombox(ComboBox cbo, string sql)
        {
            using (SqlConnection conn = new SqlConnection(StrSqlConnection))
            {
                conn.Open();
                using (SqlDataAdapter adapter = new SqlDataAdapter(sql, conn))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    DataTable dt = ds.Tables[0];
                    cbo.DataSource = dt;
                    cbo.DisplayMember = "Display";
                    cbo.ValueMember = "ID";

                    //var columnHeaders = dt.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray();
                    //cbo.DisplayMember = columnHeaders[1];
                    //cbo.ValueMember = columnHeaders[0];
                }
            }
        }
        
        public static DataTable GetData(string sql)
        {
            using (SqlConnection conn = new SqlConnection(StrSqlConnection))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                return ds.Tables[0];
            }
        }

        public static DataTable GetData(string sql, Dictionary<string, Object> columnAndItsValue)
        {
            using (SqlConnection conn = new SqlConnection(StrSqlConnection))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                
                foreach (var item in columnAndItsValue)
                {
                    string _key = "@" + item.Key.ToString();
                    adapter.SelectCommand.Parameters.AddWithValue(_key, item.Value);
                }

                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static string InsertDataToDb(string insertQuery)
        {
            //1Connectin (StrSqlConnection)
            using (SqlConnection conn = new SqlConnection(MssqlHelper.StrSqlConnection))
            {
                //2) Connection Open
                conn.Open();
                
                //3) SqlCommand (InsertSql, Connection)
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    //4) Execute
                    cmd.ExecuteNonQuery();
                    return "Successfully Added.";
                }
            }
        }

        public static string DeleteDataFromDb(string deleteQuery)
        {
            //1Connectin (StrSqlConnection)
            using (SqlConnection conn = new SqlConnection(MssqlHelper.StrSqlConnection))
            {
                //2) Connection Open
                conn.Open();

                //3) SqlCommand (InsertSql, Connection)
                using (SqlCommand cmd = new SqlCommand(deleteQuery, conn))
                {
                    //4) Execute
                    cmd.ExecuteNonQuery();
                    return "Successfully Deleted.";
                }
            }
        }

        public static string AddData(string tableName, Dictionary<string, Object> columnAndItsValue)
        { 
            using (SqlConnection conn = new SqlConnection(MssqlHelper.StrSqlConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    string columns = "";
                    string columnValues = "";
                    foreach (var item in columnAndItsValue)
                    {
                        columns += item.Key.ToString() + ",";
                        columnValues += "@" + item.Key.ToString() + ",";
                    }
                    if (columns != "")
                    {
                        columns = columns.TrimEnd(',');
                        columnValues = columnValues.TrimEnd(',');
                    }

                    string sql = string.Format("INSERT INTO {0} ({1}) VALUES ({2})", tableName, columns, columnValues);
                    cmd.CommandText = sql;

                    //add parameter with values.
                    foreach (var item in columnAndItsValue)
                    {
                        string _key = "@" + item.Key.ToString();
                        cmd.Parameters.AddWithValue(_key, item.Value);
                    }

                    //Execute
                    cmd.ExecuteNonQuery();

                    return "Successfully Added.";
                }
            }
        }

        public static string UpdateData(string tableName, Dictionary<string, Object> columnAndItsValue, string Id)
        {
            using (SqlConnection conn = new SqlConnection(MssqlHelper.StrSqlConnection))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    string columnAndValues = "";
                    foreach (var item in columnAndItsValue)
                    {
                        columnAndValues += item.Key.ToString() + "=@" + item.Key.ToString() + ",";
                        
                    }
                    if (columnAndValues != "")
                    {
                        columnAndValues = columnAndValues.TrimEnd(',');
                    }
                    
                    string sql = string.Format("UPDATE {0} SET {1} WHERE {2}", tableName, columnAndValues, Id);
                    cmd.CommandText = sql;

                    //add parameter with values.
                    foreach (var item in columnAndItsValue)
                    {
                        string _key = "@" + item.Key.ToString();
                        cmd.Parameters.AddWithValue(_key, item.Value);
                    }

                    //Execute
                    cmd.ExecuteNonQuery();

                    return "Successfully Added.";
                }
            }
        }

        public static void BackupDatabase(string databaseName, string filePath)
        {
            using (SqlConnection conn = new SqlConnection(StrSqlConnection))
            {
                conn.Open();
                string sql = "Backup database " +databaseName+ " to disk='"+ filePath +"'";
                using (SqlCommand cmd = new SqlCommand(sql, conn)) 
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
