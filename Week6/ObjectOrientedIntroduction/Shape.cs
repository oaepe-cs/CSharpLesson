using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedIntroduction
{
    public class Shape
    {
        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public decimal CalculateArea(decimal width, decimal height)
        {
            return (width * height);
        }

        public virtual void Method1(){}
    }
}
