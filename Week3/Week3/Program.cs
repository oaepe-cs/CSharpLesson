using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class Program
    {
        static void StructMain(string[] args)
        {
            int x = 10;
            int y = x;
            y = 20;

            Point p = new Point(10, 5);
            //p.Show();

            Point p2 = p;
            p2.Show();
            p2.x = 100;

            Console.WriteLine("struct Point");
            Console.WriteLine("P1 " + p.x);
            Console.WriteLine("P2 " + p2.x);

            
        }
    }

    struct Point
    {
        public int x;
        public  int y;

        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }

        public void Show()
        {
            Console.WriteLine("X: " + x + " Y: " + y);
        }
    }
}
