using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    class MethodOptionalParameters
    {        
        static void Main()
        {
            //Call method with opitional parameter with values
            MethodOptionalParameters.Sum(10, 20, 70);

            //Call method without opitional parameter
            Sum(10, 20);

            Sum();

            int result = Sum(5);
            Console.WriteLine("Ouput result from return type Sum Method: " + result);

            Show(25, "Mg Mg");

            Show("Ko Ko", 30);
            Console.ReadLine();
        }

        //Method Optional Paramenter
        //Have 2 parameters
        //Have 1 opitional paramenter
        static void Sum(int num1, int num2, int num3 = 10)
        {
            int result = num1 + num2 + num3;
            Console.WriteLine("Result: " + result);
        }        

        static int Sum(int number)
        {
            return 20 + number;
        }

        static void Sum()
        {
            Console.WriteLine("Sum: " + 100 + 200);
        }

        static void Show(string name, int age)
        {
            //string strTest = "Mg Mg told \"He will go bangkok soon.\"";
            string strResult = string.Format("{1} is {0} years old.",  age, name);
            strResult = name + " is " + age + " years old.";
            Console.WriteLine(strResult);
        }

        static void Show(int age, string name)
        {
            string strResult = string.Format("Hello {0}. {1} is {2} years old.", name, name, age);
            Console.WriteLine(strResult);
        }
    }
}
