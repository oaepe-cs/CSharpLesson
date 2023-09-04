using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    //Define
    delegate void CallMe(string firstString);

    class DelegateType
    {
        static void DelegateTypeMain()
        {
            //Declare
            CallMe fistDel;

            //Intialize
            fistDel = Test.GoodBye;            
            fistDel("Mg Mg");

            CallMe eatDel;
            eatDel = Eat;
            eatDel("Bread");

            Console.ReadLine();
        }

        static void Eat(string food)
        {
            Console.WriteLine("Eating lunch : " + food);
        }
    }

    class Test
    {
        public static void Hello(string firstName)
        {
            Console.WriteLine("Hello " + firstName);
        }

        public static void GoodBye(string firstName)
        {
            Console.WriteLine("GoodBye " + firstName);
        }
    }
}
