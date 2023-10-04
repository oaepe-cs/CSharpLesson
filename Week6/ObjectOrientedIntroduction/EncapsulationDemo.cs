using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ObjectOrientedIntroduction
{
    class EncapsulationDemo
    {

    }

    public class Venhicle
    {
        internal void InternalMethod() { }
        protected internal void GetMillage()
        {
            Console.WriteLine("Protected Internal Method called.");
        }

        protected void GetMillage(string protectedMethod)
        {
            Console.WriteLine("Protected Method called. " + protectedMethod);
        }

        private void CallMethod()
        {
            GetMillage();
            GetMillage("with parameters");
        }

        //public void PubicClass() { }
    }

    class Car : Venhicle
    {
        private void CallMethod()
        {
            Venhicle v = new Venhicle();
            
            Car c = new Car();
            c.GetMillage();
            c.GetMillage("winthin the same library protected method called.");
        }
    }
}
