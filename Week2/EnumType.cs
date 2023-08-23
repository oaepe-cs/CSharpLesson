using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class EnumType
    {
        static void EnumTypeExample()
        {
            string day = DaysOfWeeks.Friday.ToString();
            Console.WriteLine(day);
            int sunday = (int)DaysOfWeeks.Wednesday;
            Console.WriteLine(sunday);
            Console.ReadLine();
        }
    }

    enum DaysOfWeeks
    {
        Sunday = 1000,
        Monday = 2,
        Tuesday = 3,
        Wednesday = 400,
        Thursday = 5,
        Friday = 6,
        Saturday = 7
    }
}
