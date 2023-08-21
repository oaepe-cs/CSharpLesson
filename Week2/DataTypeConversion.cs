using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class DataTypeConversion
    {
        //Explicit  Vs Implicit in C#
        static void Main()
        {
            //Implicit Conversion
            int num1 = int.MaxValue;
            uint unum1 = Convert.ToUInt32(num1);

            double fNum1 = Convert.ToDouble(num1);

            Console.WriteLine("Num1: " + num1);
            Console.WriteLine("unum1: " + unum1);
            Console.WriteLine("double: " + fNum1);

            //Explicit Conversion
            double doubleA = 20.10;
            int intA = Convert.ToInt32(doubleA);
            Console.WriteLine("doubleA " + doubleA);
            Console.WriteLine("intA " + intA);

            string two = "2a";
            //int intTwo = Convert.ToInt32(two);
            Console.WriteLine("two " + two);
            //Console.WriteLine("intTwo " + intTwo);

            Convert.ToInt32(two);
            int.Parse(two);
            
            //int intTwo1 = 
            //Console.WriteLine("intTwo1 " + intTwo1);
            

            


            Console.ReadLine();
        }
    }
}
