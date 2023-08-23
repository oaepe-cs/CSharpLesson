using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class DataTypeConversion2
    {
        static void Main4()
        {
            //Implicit Conversion
            int intNum1 = 20;
            Console.WriteLine("Integer: " + intNum1);
            long lNum1 = Convert.ToInt32(intNum1);
            Console.WriteLine("Long: " + lNum1);
            double impConvertNum1 = Convert.ToDouble(intNum1);
            Console.WriteLine("impConvertNum1 :" + impConvertNum1);


            //Explicit conversion
            double dNum1 = 20.55;
            Console.WriteLine("dNum1: "+ dNum1);
            int expConvertNum1 = Convert.ToInt32(dNum1);
            Console.WriteLine("expConvertNum1: " + expConvertNum1);

            int result = 100;
            string num1= null;
            result = Convert.ToInt32(num1);
            //result = int.Parse(num1);
            int.TryParse(num1, out result);

            Console.ReadLine();

        }
    }
}
