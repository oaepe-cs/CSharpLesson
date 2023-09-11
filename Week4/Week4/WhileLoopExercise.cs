using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    class WhileLoopExercise
    {
        static void WhileLoopExerciseMain()
        {
            //65
            //User Input 23 (Your number is small);
            //98 (Your number is big)
            //65 => (Ok);

            Console.WriteLine("Guess a number.");
            Random rand = new Random();
            int randomRumber = rand.Next(0, 100); //returns random number between 0-99
            int guessNumber = -1;
            bool tfOkay = true;
            do{
                Console.WriteLine("Enter a number between 0 to 100");
                int.TryParse(Console.ReadLine(), out guessNumber);
                if (guessNumber > randomRumber)
                {
                    Console.WriteLine("Your number is big");
                }
                else if (guessNumber < randomRumber)
                {
                    Console.WriteLine("Your number is small");
                }
                else
                {
                    tfOkay = false;
                    Console.WriteLine("Ok!");
                }
            } while (tfOkay);


            Console.ReadLine();
        }
    }
}
