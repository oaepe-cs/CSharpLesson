using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1.Model
{
    public class Bird : AbstractAnimal
    {
        public string Name { get; set; }
        public Bird(string name)
        {
            Name = name;
        }

        public override void Eat(string food)
        {
            Console.WriteLine("Call from Bird Class.");
            Console.WriteLine(Name + " eat " + food);
        }

        public void Fly()
        {
            Console.WriteLine("Bird can fly.");
        }
    }
}
