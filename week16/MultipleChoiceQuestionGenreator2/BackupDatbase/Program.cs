using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;

namespace BackupDatbase
{
    class Program
    {
        public static string StrSqlConnection = "";
        static void Main(string[] args)
        {            
            string currentDirctory = Environment.CurrentDirectory;
            string fileName = "";
            string databaseName = "";
            string configFilePath = currentDirctory + "\\config.txt";
            const Int32 BufferSize = 128;
            using (var fileStream = File.OpenRead(configFilePath))
            using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
            {
                string configLines = "";
                String line ;
                while ((line = streamReader.ReadLine()) != null)
                {
                    configLines += line + "|";
                }
                var arrConfig = configLines.Split('|');
                StrSqlConnection = arrConfig[0].Trim();
                databaseName = arrConfig[1].Trim();
                fileName = arrConfig[2].Trim();                
            }

            Console.WriteLine("Database Backup Start running.");

            fileName = string.Format("{0}_{1}.bak",  fileName, DateTime.Now.DayOfWeek);
            string filePath = currentDirctory + "\\" + fileName;
            BackupDatabase("MultipleChoicesQuestionGenerator", filePath);
            Console.WriteLine("Done.");
        }

        public static void BackupDatabase(string databaseName, string filePath)
        {
            using (SqlConnection conn = new SqlConnection(StrSqlConnection))
            {
                conn.Open();
                string sql = "Backup database " + databaseName + " to disk='" + filePath + "'";
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
