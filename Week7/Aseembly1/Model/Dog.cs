using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1.Model
{
    public class Dog : Animal
    {
        public Dog(string name): base(name)
        {
            Name = name;
        }

        public override void Eat(string food)
        {
            Console.WriteLine("Call from Dog Class.");
            Console.WriteLine(Name + " eat " + food);
        }
    }
}
