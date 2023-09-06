using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class SwitchCaseStatement
    {
        static void SwitchCaseStatementMain()
        {
            Console.WriteLine("Please Enter a day (1 - 7)");
            int Day = int.Parse(Console.ReadLine());
            switch (Day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Wednesday");
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    break;
                case 7:
                    Console.WriteLine("Saturday");
                    break;
                default:
                    Console.WriteLine("Not Found.");
                    break;
            }

            Console.WriteLine("Enter AM or PM");
            string hourStatus = Console.ReadLine();
            switch (hourStatus.ToLower())
            {
                case "am":
                    Console.WriteLine("Morning...");
                    break;
                case "pm":
                    Console.WriteLine("Afternoon");
                    break;
                default:
                    Console.WriteLine("Not found.");
                    break;
            }


            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
