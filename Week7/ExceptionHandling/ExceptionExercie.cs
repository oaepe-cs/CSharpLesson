using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandling
{
    public class ExceptionExercie
    {
        public static void TestArgumentOurOfRangeException()
        {
            string str = "SpringC#";
            Console.WriteLine(str.Substring(6, 3));
        }

        public static void TestIndexOutOfRangeException()
        {
            string[] array = { "a", "A", "b", "B" };

            Console.WriteLine(array[5]);
        }

        public void DivideTwoNumber()
        {
            Console.WriteLine("Enter Number1.");
            int Number;
            int.TryParse(Console.ReadLine(), out Number);

            Console.WriteLine("Enter Number2.");
            int divBy;
            int.TryParse(Console.ReadLine(), out divBy);
            int divResult = Number / divBy;
        }

        public static void ValidateAge(int age)
        {
            if (age > 0)
            {
                Console.WriteLine("Age: " + age);
            }
            else
            {
                throw new MyCustomizedException("Age number must not be negative.");
            }
        }
    }
}
