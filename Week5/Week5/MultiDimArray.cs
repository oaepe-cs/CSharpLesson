using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week5
{
    class MultiDimArray
    {
        static void MultiDimArrayMain()
        {
            //Declare array with fixed length
            int[,] twoDimArray = new int[3, 5] {
                                     {0, 1, 2, 3, 4},
                                     {10, 11, 12, 13, 14},
                                     {20, 21, 22, 23, 2}
                                 };

            Console.WriteLine(twoDimArray[2, 2]);

            //Declare array without array index
            int[,] twoDimArray1 = { 
                                    {1, 2, 3, 4, 5},
                                    {10, 11, 12, 13, 14},
                                    {20, 21, 22, 23, 24},
                                    {31, 32, 33, 34, 33}
                                  };

            int rowLength = twoDimArray1.GetLength(0);
            Console.WriteLine("Row: " + rowLength);
            int colLength = twoDimArray1.GetLength(1);
            Console.WriteLine("Col: " + colLength);

            //Console.WriteLine(twoDimArray1[0, 0]); //1
            //Console.WriteLine(twoDimArray1[0, 1]); //2
            //Console.WriteLine(twoDimArray1[0, 2]); //3
            //Console.WriteLine(twoDimArray1[0, 3]); //4
            //Console.WriteLine(twoDimArray1[0, 4]); //5

            for (int i = 0; i < rowLength; i++)
            {
                Console.WriteLine("Row: " + i);
                for (int j = 0; j < colLength; j++)
                {
                    int _arrayValue1 = twoDimArray1[i, j];
                    string strArrValue1 = string.Format("twoDimArray[{0},{1}] : {2}", i, j, _arrayValue1);
                    Console.WriteLine(strArrValue1);
                }
            }

            Console.WriteLine("");
            Console.WriteLine("ThreeDimArray");
            int[, ,] threeDimArray = new int[3, 5, 4]
                                    {
                                         {
                                             {10,11,12,0}, 
                                             {20,21,22,0},
                                             {30,31,32,0},
                                             {40,41,432,0},
                                             {50,55,100, 0},
                                         },
                                         {
                                             {10,11,12, 1}, 
                                             {20,21,22, 1},
                                             {30,31,32, 1},
                                             {40,41,432, 1},
                                             {50,55,100, 1}
                                         },
                                         {
                                             {10,11,12, 2}, 
                                             {20,21,22, 2},
                                             {30,31,32, 2},
                                             {40,41,432, 2},
                                             {50,55,100, 2}
                                         }
                                    };
            for (int i = 0; i < threeDimArray.GetLength(0); i++)
            {
                Console.WriteLine("First Loop" + i);
                for (int j = 0; j < threeDimArray.GetLength(1); j++)
                {
                    Console.WriteLine("Second Loop" + j);
                    for (int x = 0; x < threeDimArray.GetLength(2); x++)
                    {
                        int _arrayValue1 = threeDimArray[i, j, x];
                        string strArrValue1 = string.Format("ThreeDimArray[{0},{1},{3}] : {2}", i, j, _arrayValue1, x);
                        Console.WriteLine(strArrValue1);
                    }
                }
            }

            string[,] strTwoDimArray = new string[3,2]{
                                           {"Apple", "Orange"},
                                           {"Tea", "Coffee"},
                                           {"Noodle", "Rice"}
                                       };
            for (int i = 0; i < strTwoDimArray.GetLength(0); i++)
            {
                for (int j = 0; j < strTwoDimArray.GetLength(1); j++)
                {
                    Console.WriteLine("StrTowDimArray[" + i + ", " + j + "] :" + strTwoDimArray[i, j]);
                }
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
