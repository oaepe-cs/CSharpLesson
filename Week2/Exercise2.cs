using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class Exercise2
    {
        static void Main5()
        {
            /*
             1
            Write a C# Sharp program to print the results of the specified operations.
            Test data:

            -1 + 4 * 6
            ( 35+ 5 ) % 7
            14 + -4 * 6 / 11
            2 + 15 / 6 * 1 - 7 % 2 
            */
            Console.WriteLine("No. 1");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            /*
            2        
            Write a C# Sharp program to print on screen the output of adding, subtracting, 
            multiplying and dividing two numbers entered by the user.
            Test Data:
            Input the first number: 25
            Input the second number: 4
            Expected Output:
            25 + 4 = 29
            25 - 4 = 21
            25 x 4 = 100
            25 / 4 = 6
            25 mod 4 = 1
            */
            Console.WriteLine("****************************************");
            Console.WriteLine("No. 2");
            Console.WriteLine("Input the first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number: ");
            int num2 = int.Parse(Console.ReadLine());
            int result = num1 + num2;
            Console.WriteLine(num1 + " + " + num2 + " = " + result);
            result = num1 - num2;
            Console.WriteLine(num1 + " - " + num2 + " = " + result);
            result = num1 * num2;
            Console.WriteLine(num1 + " x " + num2 + " = " + result);
            result = num1 / num2;
            Console.WriteLine(num1 + " / " + num2 + " = " + result);
            result = num1 % num2;
            Console.WriteLine(num1 + " mod " + num2 + " = " + result);

            /* 3
             Write a C# Sharp program that prints the multiplication table of a number as input.
             Test Data:
             Enter the number: 5
             Expected Output:
             5 * 0 = 0
             5 * 1 = 5
             5 * 2 = 10
             5 * 3 = 15
             ....
             5 * 10 = 50 
             */
            Console.WriteLine("****************************************");
            Console.WriteLine("No. 3");

            Console.WriteLine("Enter the number.");
            int number = int.Parse(Console.ReadLine());
            int intResult = number * 0;
            Console.WriteLine(number + "*" + 0 + " = " + intResult);
            intResult = number * 1;
            Console.WriteLine(number + "*" + 1 + " = " + intResult);
            intResult = number * 2;
            Console.WriteLine(number + "*" + 2 + " = " + intResult);
            intResult = number * 3;
            Console.WriteLine(number + "*" + 3 + " = " + intResult);
            intResult = number * 4;
            Console.WriteLine(number + "*" + 4 + " = " + intResult);
            intResult = number * 5;
            Console.WriteLine(number + "*" + 5 + " = " + intResult);
            intResult = number * 6;
            Console.WriteLine(number + "*" + 6 + " = " + intResult);
            intResult = number * 7;
            Console.WriteLine(number + "*" + 7 + " = " + intResult);
            intResult = number * 8;
            Console.WriteLine(number + "*" + 8 + " = " + intResult);
            intResult = number * 9;
            Console.WriteLine(number + "*" + 9 + " = " + intResult);
            intResult = number * 10;
            Console.WriteLine(number + "*" + 10 + " = " + intResult);


            /*4
            Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z.
            Test Data:
            Enter first number - 5
            Enter second number - 6
            Enter third number - 7 
            */
            Console.WriteLine("****************************************");
            Console.WriteLine("No. 4");
            Console.WriteLine("Enter first number -");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter second number -");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter third number-");
            double z = Convert.ToDouble(Console.ReadLine());

            double output1 = (x + y) * z;
            Console.WriteLine("Output1 " + output1);
            double output2 = x * y + y * z;
            Console.WriteLine("Output2 " + output2);
            Console.ReadLine();
        }
    }
}
