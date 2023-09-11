using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week4
{
    //Week3 Exercise
    class Program
    {
        static void Week3ExerciseMain(string[] args)
        {
            //1) 
            //Write a C# Sharp program to read temperature in centigrade and 
            //display a suitable message according to the temperature state below:
            //Temp < 0 then Freezing weather
            //Temp 0-10 then Very Cold weather
            //Temp 10-20 then Cold weather
            //Temp 20-30 then Normal in Temp
            //Temp 30-40 then Its Hot
            //Temp >=40 then Its Very Hot
            //Test Data :
            //44
            //Expected Output :
            //Its very hot.

            Console.WriteLine("Enter the temperature.");
            string strTemperature = Console.ReadLine();
            float fTemperature;
            //Convert user's keyed temperature to float.
            float.TryParse(strTemperature, out fTemperature);
            if (fTemperature < 0)
            {
                Console.WriteLine("Freezing weather.");
            }
            else if (fTemperature >= 0 && fTemperature < 10)
            {
                Console.WriteLine("Very Cold weather");
            }
            else if (fTemperature >= 10 && fTemperature < 20)
            {
                Console.WriteLine("Cold weather");
            }
            else if (fTemperature >= 20 && fTemperature < 30)
            {
                Console.WriteLine("Normal weather");
            }
            else if (fTemperature >= 30 && fTemperature < 40)
            {
                Console.WriteLine("Hot weather");
            }
            else if (fTemperature >= 40)
            {
                Console.WriteLine("Very Hot weather");
            }


            //2) 
            //Write a C# Sharp program to check whether an alphabet letter is a consonant or a vowel.
            //Test Data :
            //l
            //Expected Output :
            //The alphabet is a consonant.

            //a, e, i, o, u

            Console.ReadLine();
        }
    }
}
