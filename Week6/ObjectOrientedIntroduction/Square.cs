using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedIntroduction
{
    public class Square : Shape
    {
        public string Name { get; set; }

        public void GetName()
        {
            Console.WriteLine("Name: " + Name);
        }

        public sealed override void Method1()
        {
            Console.WriteLine("Abc");
        }
    }
}
