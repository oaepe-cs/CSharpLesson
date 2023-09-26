using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculateTwoNubers;

namespace Week6
{
    class ClassDemo
    {
        string number1;
        static string number2;
        static void Main()
        {
            NormalClass();

            //Static Class
            decimal totalNum = MathUtilities.AddTwoNumber(10, 20);
            Console.WriteLine(totalNum);

            //Partial Class
            Cat objCat = new Cat();
            objCat.Name = "Shwe Wah";
            objCat.Color = "Gold";
            objCat.Eat();

            Console.ReadLine();
        }

        private static void NormalClass()
        {
            Person objP = new Person("-");
            objP.Age = 9;
            objP.Eat();

            Person objP1 = new Person("Mg Mg");
            objP1.Age = 39;
            

            Console.WriteLine("objP Name: " + objP.Name);

            if (objP.Age < 10)
            {
                Person objB = objP;
                objB.Age = 31;
                Person.Place = "Myanmar";

                Console.WriteLine("Age: " + objB.Age);
            }


            
        }
    }
}
