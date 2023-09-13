using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    class ForLoop
    {
        static void ForLoopMain()
        {
            //for loop
            //for(initialization; condition; increment/decrement)
            //{ 
        
            //}
            //Increment
            int i = 1;
            for (i=1; (i <= 10); i = i + 1)
            {
                Console.WriteLine(i + 100);
            }
            
            //Decrement
            for (i = 10; (i >= 0); i = i - 3)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            for (int x = 0; x < 10; x = x + 2)
            {
                Console.WriteLine("X " + x);
            }

            int[] arr = new int[11];
            arr[0] = 100;
            arr[1] = 105;
            arr[2] = 110;
            arr[3] = 120;
            arr[4] = 125;
            arr[5] = 130;
            arr[6] = 135;
            arr[7] = 140;
            arr[8] = 145;
            arr[9] = 150;

            int totalSum = 0;
            for (int c = 0; c < arr.Length; c++)
            {
                if (c % 2 == 0)
                {
                    totalSum = totalSum + arr[c];
                    Console.WriteLine("Arr[" + c + "]: " + arr[c]);
                }                
            }
            Console.WriteLine("Total Sum: " + totalSum);


            //Factorial
            //3! => 3*2*1= 6
            //5! => 5*4*3*2*1 = 120
            Console.WriteLine("Enter Number fro Factorial Calculation");
            int num = int.Parse(Console.ReadLine());
            int result = 1;
            for (int j = 1; j <= num; j++)
            {
                result = result * j;
            }
            Console.WriteLine("Result :" + result);

            //Nested Loop
            for (int x = 1; x <= 5; x++)
            {
                Console.WriteLine("x :" + x);
                for (int y = 1; y <= 10; y++)
                {
                    Console.WriteLine("..: " + y);
                }
            }

            int[] temArr = arr;
            foreach (int y in temArr)
            {
                Console.WriteLine(y);
            }
            string[] strArr = new string[2];
            strArr[0] = "Weekdays";
            strArr[1] = "Weekend";

            string[] strArray = new string[]
            {
                "Sunday", 
                "Monday",
                "Tuesday",
                "Wednesday",
                "Thursday",
                "Friday",
                "Saturday"
            };

            //For
            for (int weekDays = 0; weekDays < strArr.Length; weekDays++)
            {
                Console.WriteLine("Weeks: " + strArr[weekDays]);
                for (int days = 0; days < strArray.Length; days++)
                {
                    Console.WriteLine("Days: " + strArray[days]);
                }
            }
            
            //ForEach
            foreach (string week in strArr)
            {
                string outPut = string.Format("It comes from Foreach {0}", week);
                Console.WriteLine(outPut);
            }

            foreach (var item in strArray)
            {
                string output = string.Format("Foreach {0}", item);
                Console.WriteLine(output);
            }

            Console.WriteLine("End of Foor looop.");
            Console.ReadLine();
        }

        
    }
}
