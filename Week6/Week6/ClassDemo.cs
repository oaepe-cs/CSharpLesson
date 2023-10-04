using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculateTwoNubers;
using ObjectOrientedIntroduction;

namespace Week6
{
    class ClassDemo : Venhicle
    {
        
        private static void CallMethod()
        {
            Venhicle obj1 = new Venhicle();
           

            ClassDemo obj = new ClassDemo();
            obj.GetMillage();
            obj.GetMillage("thanks");
            

        }
        string number1;
        static string number2;
        static void Main()
        {
            CallMethod();
            NormalClass();

            //Static Class
            decimal totalNum = MathUtilities.AddTwoNumber(10, 20);
            Console.WriteLine(totalNum);

            //Partial Class
            Cat objCat = new Cat();
            objCat.Name = "Shwe Wah";
            objCat.Color = "Gold";
            objCat.Eat();

            //Gerneric Class
            GeneriClasExample();

            //InheritIntro
            Shape s = new Shape();
            s.Height = 10;
            s.Width = 10;
            var sResult = s.CalculateArea(10, 29);
            Console.WriteLine("Area: " +sResult);

            Square sq = new Square();
            sq.Name = "Square";
            var sqResult = sq.CalculateArea(10, 10);
            Console.WriteLine("sq Area: " + sqResult);


            
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

        private static void GeneriClasExample()
        {
            MyGenericClass<int> myFirstGenericObj = new MyGenericClass<int>(95);
            int myFirstGenericObjectValue = myFirstGenericObj.GetValue();

            Console.WriteLine(myFirstGenericObjectValue);

            MyGenericClass<string> mySecondGenericObj = new MyGenericClass<string>("Spring C#");
            string mySecondGenericObjValue = mySecondGenericObj.GetValue();
            Console.WriteLine(mySecondGenericObjValue);

            Cat catObj = new Cat();
            catObj.Name = "Shwe wha";
            
            Cat catObj1 = new Cat
            {
                Name = "CatObj1",
                Color = "Brown"
            };
            
            catObj.Color = "Black";
            MyGenericClass<Cat> myThirdGenericObj = new MyGenericClass<Cat>(catObj1);
            var objValue = myThirdGenericObj.GetValue();
            Console.WriteLine("Name: " + objValue.Name + " Color: " + objValue.Color);
        }
    }
}
