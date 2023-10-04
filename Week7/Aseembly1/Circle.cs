using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1
{
    public class Circle : Shape
    {
        int num1 = 10;
        const float PI = 3.142f;

        private void Method()
        {
            num1 = 20;            
            Circle c = new Circle();
            
        }

        public override float GetArea()
        {
            Console.WriteLine("Get Area function of circle");
            float radius = 5;
            return (PI * (radius * radius));
        }
    }
}
