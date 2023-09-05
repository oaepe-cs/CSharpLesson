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

        static void ConditionalStatementExerciseMain()
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

            Console.WriteLine("Enter a year");
            int intYear = Convert.ToInt32(Console.ReadLine());            
            int result = intYear % 4;
            if (result == 0)
            {
                Console.WriteLine( intYear + " is a leap year.");
            }
            else
            {
                Console.WriteLine(intYear + " is not a leap year.");
            }

            //Enter a number
            //between 0 to 20 (Young);

            //20 - 40 (Adult);

            //greater 40 (Old);

            Console.ReadLine();
        }
    }
}
