using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week7
{
    internal class DestractorClass : IDisposable
    {
        public DestractorClass()
        {
            Console.WriteLine("Start Method.");
        }
        public DestractorClass(string name)
        {

        }

        public int Id { get; set; }
        public string Name { get; set; }

        public void CallMethod()
        {
            Console.WriteLine("Method called.");
        }

        //~DestractorClass()
        //{
        //    Console.WriteLine("End Method.");
        //}
        public void Dispose()
        {
            Console.WriteLine("End Method.");
        }
    }
}
