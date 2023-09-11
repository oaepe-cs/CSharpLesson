using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    class WhileLoop
    {
        static void WhileLoopMain()
        {
            Random rand = new Random();
            int randomRumber = rand.Next(0, 100); //returns random number between 0-99
            bool tfNumberGreaterThanFive = true;
            //While Loop
            while (tfNumberGreaterThanFive)
            {


                Console.WriteLine("Random number: " + randomRumber);
                Console.WriteLine("Enter Number!");
                int num = int.Parse(Console.ReadLine());
                if (num < 5)
                {
                    tfNumberGreaterThanFive = false;
                }
                else
                {
                    Console.WriteLine("Number: " + num);
                }
            }

            bool tfNumberLessThanFive = false;
            //DoWhile Loop
            do{
                Console.WriteLine("Enter Number for Do while loop.");
                int num = int.Parse(Console.ReadLine());
                if (num < 5)
                {
                    tfNumberLessThanFive = true; 
                    Console.WriteLine("Number: " + num);
                }
                else
                {
                    tfNumberLessThanFive = false;
                    Console.WriteLine("Quit Do While loop");
                }
            } while (tfNumberLessThanFive);

            
            //65
            //User Input 23 (Your number is small);
            //98 (Your number is big)
            //65 => (Ok);

            Console.ReadLine();
        }
    }
}
