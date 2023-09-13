using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    class Methods
    {
        static void MethodsMain()
        {
            //Call Instance Method in Static Method
            Methods newObject = new Methods();
            newObject.Show("Mg Mg");

            //Call static method in Static Method
            Eat("Mg Mg", "apple");

            int sumResult = Calculation.Sum(1,3);
            Calculation calObject = new Calculation();
            calObject.ShowCalculateResult(sumResult);

            Console.ReadLine();
        }

        private static void Eat(string name, string food)
        {
            Console.WriteLine(name + " eat " + food);
        }
        
        private void Show(string name)
        {
            string upperValue;
            upperValue = name.ToUpper();
            string lowerCase = name.ToLower();

            int result = SumNumbers(70, 30);
            Console.WriteLine("Ouptput: " + result);
        }

        private int SumNumbers(int num1, int num2)
        {
            Console.WriteLine("Sum of two numbers");
            int total = num1 + num2;
            return total;
        }
    }

    class Calculation
    {
        public void ShowCalculateResult(int number)
        {
            Console.WriteLine("Result: " + number);
        }

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        private static int Sub(int num1, int num2)
        {
            return num1 - num2;
        }

        private static int Mult(int num1, int num2)
        {
            return num1 * num2;
        }

        private static int Div(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}
