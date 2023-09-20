using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week5
{
    class JaggedArray //Array of Array
    {
        static void JaggedArrayMain()
        {
            int[][] arr = new int[3][];
            arr[0] = new int[] { 1, 2, 3, 4, 5 };
            arr[1] = new int[] { 11, 12, 13 };
            arr[2] = new int[] { 21, 22, 23 };

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    int arrValue = arr[i][j];
                    Console.WriteLine(string.Format("arr[{0}, {1}]: {2}", i,j, arrValue));
                }
            }

            string[] category = { "Fruit","Food","Drink"};
            string[][] strArray = new string[3][];
            strArray[0] = new string[] { "Apple","Orange", "Banana"};
            strArray[1] = new string[] { "Rice", "Noodle", };
            strArray[2] = new string[] { "H20", "Apple Juice", "Tea", "Coffee" };

            for (int i = 0; i < strArray.Length; i++)
            {
                Console.WriteLine(category[i]);
                for (int j = 0; j < strArray[i].Length; j++)
                {
                    string arrValue = strArray[i][j];
                    Console.WriteLine(string.Format("... strArray[{0}, {1}]: {2}", i,j, arrValue));
                }
            }

            Random r = new Random();
            Console.WriteLine("Enter number to define Array Length.");
            int arrLength = int.Parse(Console.ReadLine());
            Array newArr = Array.CreateInstance(typeof(int), arrLength);
            newArr.SetValue(200, 0);
            for (int i = 0; i < arrLength; i++)
            {
                newArr.SetValue(r.Next(1, 100), i);
            }

            Console.WriteLine("Before sorting...");
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            //Get Array Length
            int newArrLength = newArr.Length;
            int arrValueOfIndexZero = 0;
            if (newArrLength > 0)
            {
                arrValueOfIndexZero = (int)newArr.GetValue(0); //Convert of type casting
            }
            Console.WriteLine("arrValueOfIndexZero: " + arrValueOfIndexZero);
            //IndexOf
            int indexCount = Array.IndexOf(newArr, arrValueOfIndexZero);
            Console.WriteLine("indexCount: " + indexCount);

            //Sort
            Array.Sort(newArr);
            Console.WriteLine("After sorting...");
            int nexIndex = 0;
            foreach (var item in newArr)
            {
                if (nexIndex == 0)
                {
                    Console.WriteLine("Smallest Number: " + item);
                }
                else if(nexIndex == 1)
                {
                    Console.WriteLine("2nd Number: " + item);
                }
                else if (nexIndex == 2)
                {
                    Console.WriteLine("Greatest Number: " + item);
                }                
                nexIndex++;
            }

            //Reverse
            Console.WriteLine("Reverse sorting...");
            Array.Reverse(newArr);
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Copy of Array");
            Array copyArray = Array.CreateInstance(typeof(int), arrLength);
            Array.Copy(newArr, copyArray, arrLength);
            foreach (var item in copyArray)
            {
                Console.WriteLine(item);
            }

            //Find
            string result = Array.Find(category, x => x.ToLower() == "f0ood");
            Console.WriteLine(result);
            int[] intArray = {100,20,250,300,325, 125 };
            int intFindResult = Array.Find(intArray, x => x > 10);
            Console.WriteLine(intFindResult);

            //FindAll
            Console.WriteLine("FindAll for Category Array");
            string[] strResultArray = Array.FindAll(category, i => !i.Contains("F"));            
            foreach (var item in strResultArray)
            {
                Console.WriteLine(item);
            }

            int[] findAllResult = Array.FindAll(intArray, x => (x % 50 != 0));
            for (int i = 0; i < findAllResult.Length; i++)
            {
                Console.WriteLine(findAllResult[i]);
            }

            Console.WriteLine("Foreach");
            foreach (var item in findAllResult)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
