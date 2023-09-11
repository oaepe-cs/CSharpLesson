using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    class ForLoop
    {
        static void Main()
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
            for (i = 10; (i >= 0); i = i - 1)
            {
                Console.WriteLine(i + 100);
            }

            Console.WriteLine("End of Foor looop.");
            Console.ReadLine();
        }
    }
}
