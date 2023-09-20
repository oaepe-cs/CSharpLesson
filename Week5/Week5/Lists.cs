using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week5
{
    class Lists
    {
        private static void MultipleChooiceQuestionObjectListTest()
        {
            List<MultipleChoiceQuestion> myQuestionList = new List<MultipleChoiceQuestion>();
            
            MultipleChoiceQuestion obj = new MultipleChoiceQuestion();
            obj.No = 1;
            obj.QuestionName = "Integer can store decimal numbers.";
            obj.AnswerA = "A: Yes";
            obj.AnswerB = "B: No.";
            obj.AnswerC = "C: -";
            obj.CorrectAnswer = 'A';
            myQuestionList.Add(obj);            

            MultipleChoiceQuestion obj2 = new MultipleChoiceQuestion();
            obj2.No = 2;
            obj2.QuestionName = "Integer can store decimal numbers.";
            obj2.AnswerA = "A: Yes";
            obj2.AnswerB = "B: No.";
            obj2.AnswerC = "C: -";
            obj2.CorrectAnswer = 'A';
            myQuestionList.Add(obj2);

            //Add
            MultipleChoiceQuestion obj3 = new MultipleChoiceQuestion();
            obj3.No = 3;
            obj3.QuestionName = "Is bool able to store chars.";
            myQuestionList.Add(obj3);

            PrintMyQuestionList(myQuestionList);

            //Count
            int myListCount = myQuestionList.Count;
            Console.WriteLine("Count: " + myListCount);

            //Contains
            bool tfContains = myQuestionList.Contains(obj3);
            Console.WriteLine(tfContains);

            //List using where
            Console.WriteLine("List with using where");
            List<MultipleChoiceQuestion> newList = myQuestionList.Where(x => x.No > 1).ToList();
            PrintMyQuestionList(newList);

            //List Order by
            Console.WriteLine("List Order by");
            List<MultipleChoiceQuestion> orderByList = myQuestionList.OrderBy(x => x.QuestionName).ToList();
            PrintMyQuestionList(orderByList);

            //List Order by Desc
            Console.WriteLine("List Order by Desc");
            List<MultipleChoiceQuestion> descOrderByList = myQuestionList.OrderByDescending(x => x.No).ToList();
            PrintMyQuestionList(descOrderByList);

            MultipleChoiceQuestion obj4 = new MultipleChoiceQuestion();
            //Remove
            bool tfRemoveSuccess = myQuestionList.Remove(obj3);
            Console.WriteLine("Remove Status: " + tfRemoveSuccess + " Count: " + myQuestionList.Count);
            PrintMyQuestionList(myQuestionList);

            //Removeat
            myQuestionList.RemoveAt(0);
            PrintMyQuestionList(myQuestionList);

            
        }

        private static void PrintMyQuestionList(List<MultipleChoiceQuestion> myQuestionList)
        {
            Console.WriteLine("Total Count: " + myQuestionList.Count);
            foreach (var item in myQuestionList)
            {
                Console.WriteLine(item.No + ") " + item.QuestionName);
            }
        }

        static void Main()
        {
            MultipleChooiceQuestionObjectListTest();
            BoxingAndUnBoxing();

            List<dynamic> myObjList = new List<dynamic>();
            myObjList.Add(1);
            myObjList.Add("Mg Mg");
            myObjList.Add(98.5);
            myObjList.Add(true);
            for (int i = 0; i < myObjList.Count; i++)
            {
                Console.WriteLine(myObjList[i]);
            }

            foreach (var item in myObjList)
            {
                Console.WriteLine(item);
            }

            List<int> myIntList = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                myIntList.Add(100 + i);
            }

            foreach (var item in myIntList)
            {
                Console.WriteLine(item);
            }

            bool tfContain = myIntList.Contains(103);
            Console.WriteLine("Conains of 103: " + tfContain);
            tfContain = myIntList.Contains(203);
            Console.WriteLine("Conains of 203: " + tfContain);
            Console.ReadLine();
        }

        private static void BoxingAndUnBoxing()
        {
            //Boxing
            Console.WriteLine("Boxing");
            int intNum = 10;
            string name = "78";
            //var 
            //dynamic
            //object
            object myObject = 5;
            Console.WriteLine("1 " + myObject);
            myObject = name;
            Console.WriteLine("2 " + myObject);

            //UnBoxing
            Console.WriteLine("UnBoxing");
            object myObject2 = 50;
            int myInt2 = (int)myObject2; //Casting
            Console.WriteLine(myInt2);
            
        }
    }
}
