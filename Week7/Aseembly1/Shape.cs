using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1
{
    public abstract class Shape
    {
        public string Name { get; set; }
        protected internal int Length { get; set; }

        public void ShowName()
        {
            if (Length > 10)
            {
                Console.WriteLine(Name + "'s lengeth is greate than 10");
            }
            else
            {
                int length = GetLength();
                Console.WriteLine(Name + "'s lengeth is less than or equal 10");
            }
        }

        private int GetLength()
        {
            if (Length > 10)
            {
                return Length;
            }
            else
            {
                return 10;
            }
        }

        public abstract float GetArea();
        
    }
}
