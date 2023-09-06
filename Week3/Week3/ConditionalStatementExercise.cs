using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class ConditionalStatementExercise
    {
        //Exercise Define Even or Odd
        //1) Enter a number --- 4
        //2) If a number is evern: "Even Number: " + 4
        //3) "Odd Number";

        static void ConditionalStatementExerciseMain() //ConditionalStatementExercise
        {
            //Console.WriteLine("Enter a number.");
            //string number = Console.ReadLine();
            //int num;
            //int.TryParse(number, out num);
            //int result = num % 2;
            //if (result == 0)
            //{
            //    Console.WriteLine("Even Number: " + num);
            //}
            //else
            //{
            //    Console.WriteLine("Odd Number: " + num);
            //}

            //Console.WriteLine("Enter a year");
            //int intYear = Convert.ToInt32(Console.ReadLine());            
            //int result = intYear % 4;
            //if (result == 0)
            //{
            //    Console.WriteLine( intYear + " is a leap year.");
            //}
            //else
            //{
            //    Console.WriteLine(intYear + " is not a leap year.");
            //}

            //Enter a number
            //between 0 to 20 (Young);
            //20 - 40 (Adult);
            //greater 40 (Old);

            //Enter Number 1 = 8
            //Enter Number 2 = 17
            //Enter Number 3 = 3
            //Greatest Number = 17
            //2 nd Greatest Number = 8
            //Smallest Number = 3
            Console.WriteLine("Enter Number 1");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 2");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Number 3");
            int num3 = int.Parse(Console.ReadLine());

            int smallestNumber;
            int secondGreatestNumber = 0;
            int greatestNumber;

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    greatestNumber = num1;
                }
                else
                {
                    greatestNumber = num3;
                }
            }
            else if (num2 > num3)
            {
                greatestNumber = num2;
            }
            else
            {
                greatestNumber = num3;
            }

            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    smallestNumber = num1;
                }
                else
                {
                    smallestNumber = num3;
                }
            }
            else if (num2 < num3)
            {
                smallestNumber = num2;
            }
            else
            {
                smallestNumber = num3;
            }

            //Nested If
            //if (num1 != greatestNumber)
            //{
            //    if (num1 != smallestNumber)
            //    {
            //        secondGreatestNumber = num1;
            //    }
            //}
            //else if (num1 != smallestNumber)
            //{
            //    if (num1 != greatestNumber)
            //    {
            //        secondGreatestNumber = num1;
            //    }
            //}
            //else if (num2 != greatestNumber)
            //{
            //    if (num2 != smallestNumber)
            //    {
            //        secondGreatestNumber = num2;
            //    }
            //}
            //else if (num2 != smallestNumber)
            //{
            //    if (num2 != greatestNumber)
            //    {
            //        secondGreatestNumber = num2;
            //    }
            //}
            //else
            //{
            //    secondGreatestNumber = num3;
            //}

            //Logical Operator test
            if (num1 != greatestNumber && num1 != smallestNumber)
            {
                secondGreatestNumber = num1;
            }
            else if (num2 != greatestNumber && num2 != smallestNumber)
            {
                secondGreatestNumber = num2;
            }
            else
            {
                secondGreatestNumber = num3;
            }

            Console.WriteLine("Greatest Number: " + greatestNumber);
            Console.WriteLine("Second Greatest Number: " + secondGreatestNumber);
            Console.WriteLine("Smallest Number: " + smallestNumber);

            Console.ReadLine();
        }
    }
}
