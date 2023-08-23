using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class Exercise1
    {
        static void Main3()
        {
            ////Add two numbers from user
            //Console.WriteLine("Please type Number 1.");
            //string num1 = Console.ReadLine();
            //int intNum1 = Convert.ToInt32(num1);

            //Console.WriteLine("Please type Number 2.");
            //string num2 = Console.ReadLine();
            //int intNum2 = Convert.ToInt32(num2);

            //Console.WriteLine("Addition (+)");
            //Console.WriteLine(intNum1 + intNum2);
            

            ////Modulus (%) from user
            //Console.WriteLine("Please type Number 1.");
            //string num1 = Console.ReadLine();
            //int intNum1 = int.Parse(num1);

            //Console.WriteLine("Please type Number 2.");
            //string num2 = Console.ReadLine();
            //int intNum2 = int.Parse(num2);
            
            //Console.WriteLine("Modulus (%)");
            //Console.WriteLine(intNum1 % intNum2);

            //Increment (++)
            //Console.WriteLine("Please type number.");
            //string num1 = Console.ReadLine();
            //int intNum1;
            //int.TryParse(num1, out intNum1);
            //intNum1++;
            //Console.WriteLine("Increment (++)");
            //Console.WriteLine(intNum1);

            Console.WriteLine("Please type first number.");
            int num1 = int.Parse(Console.ReadLine());

            //int tempNumber = num1;

            Console.WriteLine("Please type second number.");
            int num2 = int.Parse(Console.ReadLine());
            //num2 = tempNumber;

            int tempNum = num1;
            num1 = num2;
            num2 = num1;
            
            Console.WriteLine("After Swapping...");
            Console.WriteLine("First Number: " + num1);
            Console.WriteLine("Second Number: " + num2);
            Console.ReadLine();
        }

        void Show()
        {
            Increment();
            Console.WriteLine("Yes.");
        }

        int Increment()
        {
            Show();
            int result = 100;
            result++;
            return result;
        }
    }
}
