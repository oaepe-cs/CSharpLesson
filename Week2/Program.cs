using System;

namespace Week2
{
    class Program
    {
        static void Main1()
        {
            //uint
            uint minNumber = uint.MinValue;
            uint maxNumber = uint.MaxValue;
            Console.WriteLine("uint: " + minNumber + " to " + maxNumber);

            //long
            long minLong = long.MinValue;
            long maxLong = long.MaxValue;
            Console.WriteLine("long: " + minLong + " to " + maxLong);

            //ulong
            ulong minuLong = ulong.MinValue;            
            ulong maxuLong = ulong.MaxValue;
            Console.WriteLine("ulong: " + minuLong + " to " + maxuLong);
            
            int num = 12;
            int one = 1;
            int oneresult = num * one;
            Console.WriteLine(num + " * " + one + " = " + oneresult);
            int two = 2;
            int twoResult = num * two;
            Console.WriteLine(num + " * " + two + " = " + twoResult);
            int three = 3;
            int threeResult = num * three;
            Console.WriteLine(num + " * " + three + " = " + threeResult);
            int four = 4;
            int fourResult = num * four;
            Console.WriteLine(num + " * " + four + " = " + fourResult);
            int five = 5;
            int fiveResult = num * five;
            Console.WriteLine(num + " * " + five + " = " + fiveResult);
            int six = 6;
            int sixResult = num * six;
            Console.WriteLine(num + " * " + six + " = " + sixResult);
            int seven = 7;
            int sevenResult = num * seven;
            Console.WriteLine(num + " * " + seven + " = " + sevenResult);
            int eight = 8;
            int eightResult = num * eight;
            Console.WriteLine(num + " * " + eight + " = " + eightResult);
            int nine = 9;
            int nineReult = num * nine;
            Console.WriteLine(num + " * " + nine + " = " + nineReult);
            int ten = 10;
            int tenResult = num * ten;
            Console.WriteLine(num + " * " + ten + " = " + tenResult);
                    
            //float
            float minFloat = float.MinValue;
            float maxFloat = float.MaxValue;
            Console.WriteLine("float: " + minFloat + " to " + maxFloat);

            //double
            double minDouble = double.MinValue;
            double maxDouble = double.MaxValue;
            Console.WriteLine("double: " + minDouble + " to " + maxDouble);

            //decimal
            decimal minDecimal;
            minDecimal = decimal.MinValue;
            decimal maxDecimal = decimal.MaxValue;
            Console.WriteLine("decimal: " + minDecimal + " to " + maxDecimal);

            //char
            char c;
            c = '/';
            Console.WriteLine("char: " + c);

            //string
            string strName = "Name";
            Console.WriteLine("string: " + strName);

            //bool
            bool isPassed;
            isPassed = true;
            Console.WriteLine("Passed: " + isPassed);
            bool isNotPassed;
            isNotPassed = false;
            Console.WriteLine("Failed: " + isNotPassed);                       

            Console.ReadLine();
        }
    }
}
