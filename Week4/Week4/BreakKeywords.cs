using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    class BreakKeywords
    {
        //Instance members
        string name;
        int number;
        bool tfMale;

        //static members
        static decimal totalResult;

        //properties
        string FatherName { get; set; }

        //Constructor
        public BreakKeywords()
        {

        }

        public BreakKeywords(string _Name)
        {
            name = _Name;
        }

        public BreakKeywords(int _Number)
        {
            number = _Number;
        }

        public BreakKeywords(string _Name, int _Number)
        {
            name = _Name;
            number = _Number;
        }

        static void BreakKeywordsMain()
        { 
            Console.WriteLine("Start Break Statements");
            //break
            for (int i = 0; i < 10; i++)
            {
                if (i == 3)
                if (i == 5) break;
                Console.WriteLine("Break Value: " + i);
            }

        
            Console.WriteLine("Start continue Statements");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("inside loop");
                if (i == 5) continue;
                Console.WriteLine("Continue Value: " + i);
            }
            
            //goto:
            Console.WriteLine("goto test");
        repeat:
            Console.WriteLine("Enter a number less than 10");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 10)
            {
                // transfers control to repeat
                goto repeat;
            }
            Console.WriteLine(num + " is less than 10");

            Console.WriteLine("End of statements");
            Console.ReadLine();
        }
    }
}
