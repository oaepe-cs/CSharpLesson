using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1.Model
{
    public class Horse : AbstractAnimal
    {
        public string Name { get; set; }
        public Horse(string name)
        {
            Name = name;
        }
        public override void Eat(string food)
        {
            Console.WriteLine("Call from Horse Class.");
            Console.WriteLine(Name + " eat " + food);
        }

        public void Run()
        {
            Console.WriteLine("Horse can run very first.");
        }
    }
}
