using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1.Model
{
    public class Animal
    {
        //Constructor
        public Animal(string name)
        {
            Name = name;
        }

        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        //Instance Method
        public virtual void Eat(string food)
        {
            Console.WriteLine(Name + " eat " + food);
        }
    }
}
