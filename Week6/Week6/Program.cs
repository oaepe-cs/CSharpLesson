using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CalculateTwoNubers;

namespace Week6
{
    class Program
    {
        static void ProgramMain(string[] args)
        {
            int result = Calculator.AddTwoNumber(1, 2);
            Console.WriteLine(result);

            //Collection
            //Dictionary
            //Queue
            //Stack
            //Set
            //List<MultipleChoiceQuestion> myMultipleChoiceList = new List<MultipleChoiceQuestion>();
            List<int> myIntList = new List<int> { 1, 2, 3, 4, 5 };
            myIntList.Add(6);
            var getListDataByIndex = myIntList[0];

            DictionaryExample();

            Console.WriteLine("Queue");
            QueueExample();


            Console.WriteLine("Queue");
            Stack();


            Console.WriteLine("Set");
            SetExample();
            Console.ReadLine();
        }

        #region Dictionary
        private static void DictionaryExample()
        {
            //Dictionary
            Dictionary<string, List<string>> myDict = new Dictionary<string, List<string>>();
            myDict.Add(
                        "a", //Key
                        new List<string> //Value
                            {"it is the first char.", 
                                "It is Caps is 'A'" 
                            }
                      );
            myDict.Add("1", new List<string> { "Number one.", "You can do calculation." });
            myDict.Add("11", new List<string> { "Number one.", "You can do calculation." });
            myDict.Add("111", new List<string> { "Number one.", "You can do calculation." });
            myDict.Add("1111", new List<string> { "Number one.", "You can do calculation." });
            
            var firstDictValue = myDict.ElementAt(1);
            string outPutResultFromFirstIndex = string.Format("Key: {0}, Value: {1}", firstDictValue.Key, firstDictValue.Value[0]);
            Console.WriteLine(outPutResultFromFirstIndex);

            foreach (var item in myDict)
            {
                string val = "";
                List<string> myValue = item.Value;
                foreach (var myValueItem in myValue)
                {
                    val += myValueItem;
                }
                string itemData = string.Format("Ket: {0}, Value: {1}", item.Key, val);
                Console.WriteLine(itemData);
            }

            //Remove
            bool tfRemoved = myDict.Remove("1");
            Console.WriteLine(tfRemoved);
            //Count
            int _count = myDict.Count;
        }
        #endregion

        #region Queue
        //First In First Out (FIFO)
        private static void QueueExample()
        {
            Queue<int> myQueue = new Queue<int>();

            //Add value to Queue
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(0);
            myQueue.Enqueue(3);

            PrintQueue(myQueue);
            Console.WriteLine("Added");

            //Dequeue
            myQueue.Dequeue();
            PrintQueue(myQueue);
            Console.WriteLine("first tim called DeQueue");

            //Count
        }

        private static void PrintQueue(Queue<int> myQueue)
        {
            //Count
            int getCount = myQueue.Count;
            Console.WriteLine("Curent Queue Count: " + getCount);
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

        #region Stack
        //Last In Firs Out (LIFO)
        private static void Stack()
        {
            Stack<int> myStack = new Stack<int>();

            //Add value
            myStack.Push(10);
            myStack.Push(20);
            myStack.Push(5);

            int abc = myStack.Peek();
            int num = myStack.Pop();
            foreach (var item in myStack)
            {
                Console.WriteLine(item);
            }

        }
        #endregion

        #region Set
        private static void SetExample()
        {
            List<int> numbers = new List<int> { 1, 2, 2, 3, 4, 4, 5 };
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            HashSet<int> uniqueNumbers = new HashSet<int>(numbers);            
            foreach (var item in uniqueNumbers)
            {
                Console.WriteLine(item);
            }
            //Clear
            uniqueNumbers.Clear();

            numbers.Clear();
            foreach (var item in numbers)
            {
                Console.WriteLine(item);
            }

            HashSet<int> secondSet = new HashSet<int> { 100, 101, 205};
            Console.WriteLine("Count of second set: " + secondSet.Count);
            HashSet<int> thirdSet = new HashSet<int> { 200, 201, 205};
            //Union
            var returnResult = secondSet.Union(thirdSet);
            Console.WriteLine("Count of second set after union with thirdset: " + returnResult.ToList().Count);
            Console.WriteLine("Union");
            foreach (var item in returnResult)
            {
                Console.WriteLine(item);
            }

            //Interest
            Console.WriteLine("Interest");
            var interest = secondSet.Intersect(thirdSet);
            foreach (var item in interest)
            {
                Console.WriteLine(item);
            }

            //Difference
            Console.WriteLine("Difference");
            var differenceSet = thirdSet.Except(secondSet);
            foreach (var item in differenceSet)
            {
                Console.WriteLine(item);
            }
        }
        #endregion

    }
}
