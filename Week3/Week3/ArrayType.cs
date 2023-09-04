using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class ArrayType
    {
        static void ArrayTypeMain()
        {
            int x = 10;
            int y = x;
            y = 20;

            int[] arr = new int[3];
            arr[0] = 1;
            arr[1] = 20;
            arr[2] = 2;            
            Console.WriteLine("Arr: (before copied) " + arr[0]);

            int[] arr1 = arr;
            int[] arr2 = arr;
            int[] arr5 = arr;
            arr1[0] = 10000;

            Console.WriteLine("Arr: " + arr[0]);
            Console.WriteLine("Arr1: " + arr1[0]);
            Console.WriteLine("Arr5: " + arr5[0]);



            string[] strArr = new string[2] { "Mg Mg", "Mg Ba" };
            Console.ReadLine();
        }
    }
}
