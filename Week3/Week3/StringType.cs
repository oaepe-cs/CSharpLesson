using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class StringType
    {
        static void Main()
        {
            //Trim
            //Trim()
            //TrimStart()
            //TrimEnd()
            string value1 = "   Mg Mg   ";
            Console.WriteLine(value1);
            string result = value1.TrimStart();
            result = value1.TrimStart().TrimEnd();
            Console.WriteLine(result);

            //Replace
            value1 = "Sunday";
            result = value1.Replace("Sun", "Mon");

            //SubString()
            value1 = "Mg Mg is a student.";
            int strLength = value1.Length;
            int startIndex = strLength - 3;
            int length = strLength - (strLength - 3);
            result = value1.Substring(startIndex, length);
            Console.WriteLine(result);

            //Split
            var strArray = value1.Split('M');

            //Contains
            bool tfContain = value1.Contains(" aa ");

            int foundCount = value1.IndexOf("aa");

            Console.ReadLine();
        }
    }
}
