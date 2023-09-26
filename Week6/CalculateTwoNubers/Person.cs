using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculateTwoNubers
{   
    //Regular class
    public class Person
    {
        //Istance fields
        public static string Place; 
        string name;
        int age;

        public string Name { get; set; }
        
        public int Age 
        {
            get
            {
                return age;
            }
            set
            {
                if (value >= 0 && value <= 125)
                {
                    age = value;
                }
            }
        }

        //Constructor
        public Person()
        {
            Place = "Earth Planet";
        }

        public Person(string Name)
        {
            this.Name = Name;
            Place = "Earth";
        }

        //instance method
        public void Eat()
        {
            Console.WriteLine("Eat metnod called.");
        }

        //Destractor
        ~Person()
        {
            Console.WriteLine("Destractor called.");
        }
    }
}
