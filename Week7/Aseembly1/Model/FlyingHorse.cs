using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Aseembly1.Model
{
    public class FlyingHorse : IHorse, IBird
    {
        public void Run()
        {
            Console.WriteLine("Flying Horse can run.");
        }
        public int GetCountOfLegs()
        {
            return 4;
        }
        public void Fly()
        {
            Console.WriteLine("Flying Horse also can fly.");
        }
        public int GetCountOfWings()
        {
            return 2;
        }
    }
}
