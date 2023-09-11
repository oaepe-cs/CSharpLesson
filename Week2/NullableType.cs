using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class NullableType
    {
        static void Main()
        {
            int i = 10;
            decimal dec1 = 10.24m;
            string name = "Mg Mg";

            //
            int? nullInt = null;
            Console.WriteLine("Before assign value: " + nullInt);
            nullInt = -100;
            Console.WriteLine("After assign value: " +  nullInt);
            nullInt = null;
            Console.WriteLine("After assign value to null: " + nullInt);
            decimal? dd = null;
            Nullable<int> nullNumber2 = null;
            nullNumber2 = 10;

            Nullable<bool> tfTrue = null;
            tfTrue = true;
            bool? isExisted = null;
            Console.ReadLine();
            
            //Nullable Type Info
            string str = null;
            int? numOne = null;
            numOne = 10;
            Nullable<int> numTwo = null;
            numTwo = 20;
            //

        }
    }
}
