using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class DataTypeConversion
    {
        //Explicit  Vs Implicit in C#
        static void Main2()
        {
            //Implicit Conversion
            int num1 = int.MaxValue;
            uint unum1 = Convert.ToUInt32(num1);
            long lnum1 = Convert.ToInt32(num1);
            Console.WriteLine(lnum1);

            byte b1 = 255;
            byte b2 = 10;
            int converttoI1 = Convert.ToInt32(b1 + b2);
            Console.WriteLine("byte b1:" + b1);
            Console.WriteLine("ConvertToI1 :" + converttoI1);


            double fNum1 = Convert.ToDouble(num1);

            Console.WriteLine("Num1: " + num1);
            Console.WriteLine("unum1: " + unum1);
            Console.WriteLine("double: " + fNum1);

            //Explicit Conversion
            double doubleA = 20.50;
            int intA = Convert.ToInt32(doubleA);
            Console.WriteLine("doubleA " + doubleA);
            Console.WriteLine("intA " + intA);

            Console.ReadLine();
            int expConvertTestInt1 = 10;
            byte expConvertTestByte1 = Convert.ToByte(expConvertTestInt1);
            Console.WriteLine("expConvertTestInt1: " + expConvertTestInt1);
            Console.WriteLine("expConvertTestByte1: " + expConvertTestByte1);

            string two = null;
            //int intTwo = Convert.ToInt32(two);
            Console.WriteLine("two " + two);
            //Console.WriteLine("intTwo " + intTwo);

            int a = Convert.ToInt32(two);
            int intTryParseResult = 100;
            int.Parse(two);
            Console.WriteLine("Before convert:");
            Console.WriteLine("intTryParseResult: " + intTryParseResult);
            bool isConverted = int.TryParse(two, out intTryParseResult);
            Console.WriteLine("After convert");
            Console.WriteLine("intTryParseResult: " + intTryParseResult);
            
            //int intTwo1 = 
            //Console.WriteLine("intTwo1 " + intTwo1);
            

            


            Console.ReadLine();
        }
    }
}
