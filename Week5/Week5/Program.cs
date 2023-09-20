using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week5
{
    class Program
    {
        //Array
        static void ArrayMain(string[] args)
        {
            string month1 = "Januarey";
            string month2 = "February";
            string month3 = "March";

            string[] monthArr = new string[12];
            monthArr[0] = month1;
            monthArr[1] = month2;
            monthArr[11] = "December";
            monthArr[10] = "November";
            monthArr.SetValue("September", 9);

            foreach (var monthValue in monthArr)
            {
                Console.WriteLine(monthValue);
            }

            Console.WriteLine("monthArray");
            string[] monthArray =new string[]{month1, month2, month3, ""};
            int monthArrayLength = monthArray.Length;
            Console.WriteLine("monthArrayLength: " + monthArrayLength);
            foreach (var item in monthArray)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
