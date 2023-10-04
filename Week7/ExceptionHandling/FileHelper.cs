using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ExceptionHandling
{
    public static class FileHelper
    {
        public static void WriteFile(string filePath, string text, string devideString = "********************")
        {
            using (var fs = new FileStream(filePath, FileMode.Append))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.WriteLine(devideString);
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    sw.WriteLine(text);
                }
            }
        }

        public static List<string> ReadFile(string filePath)
        {
            List<string> result = new List<string>();
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    result.Add(line);
                }
            }

            return result;
        }
    }
}
