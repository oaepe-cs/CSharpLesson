using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1
{
    public class Square : Shape
    {

        public override float GetArea()
        {
            Console.WriteLine("Get Area function of Square");
            float width = 10;
            float height = 20;
            return (width * height);
        }
    }
}
