using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1.Model
{
    public abstract class AbstractAnimal
    {
        //Properties
        public string Name { get; set; }
        public string Type { get; set; }
        public string Color { get; set; }

        public abstract void Eat(string food);
    }
}
