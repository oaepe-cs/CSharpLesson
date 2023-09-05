using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class ConditionalStatements
    {
        static void Main()
        {
            bool tfFound = true;
            string num1 = "Mg Mg";
            string num2 = "MG MG";
            //Equality Operator
            bool compareResult = (num1 == num2);
            Console.WriteLine("Equality Operator: " + compareResult);

            //InEquality Operator
            compareResult = (num1 != num2);
            Console.WriteLine("InEquality Operator: " + compareResult);

            if (num1 == num2)
            {
                Console.WriteLine("If Statement found.");
            }
            else
            {
                Console.WriteLine("Out of Condition!");
            }

            int intA = 10;
            int intB = 10;
            //Greater Than Operator (>)
            bool greaterThanOperatorResult = intA > intB;
            Console.WriteLine("greaterThanOperatorResult: " + greaterThanOperatorResult);

            //Less Than Operator (<)
            bool lessThanOperatorResult = intA < intB;
            Console.WriteLine("lessThanOperatorResult: " + lessThanOperatorResult);

            //GreaterThan Or Equal
            bool greaterThanOrEqualOperatorResult = intA >= intB;
            Console.WriteLine("greaterThanOrEqualOperatorResult: " + greaterThanOrEqualOperatorResult);

            //LessThan Or Equal 
            bool lessThanOrEqualOpertorResult = intA <= intB;
            Console.WriteLine("lessThanOrEqualOpertorResult: " + lessThanOrEqualOpertorResult);

            //Logical And (&&) Operator
            int intC = 100;
            bool compareResult1 = (intA != intB);
            Console.WriteLine("compareResult1: " + compareResult1);//False
            bool compareResult2 = (intA >= intC);
            Console.WriteLine("compareResult2: " + compareResult2);//False

            bool logicalAndOperatorResult = (compareResult1 && compareResult2);
            Console.WriteLine("logicalAndOperatorResult: " + logicalAndOperatorResult); //False
            if (logicalAndOperatorResult)
            {
                Console.WriteLine("Logical And Operator (&&) result is okay."); //Not found
            }

            //Logical OR (||) Operator
            bool logicalOrOperatorResult = (compareResult1 || compareResult2);            
            Console.WriteLine("logicalOrOperatorResult: " + logicalOrOperatorResult); //False
            if (logicalOrOperatorResult)
            {
                Console.WriteLine("Logical OR Operator (||) result is okay."); //Not Found
            }

            //Logical Not (!) Operator
            bool logicalNorOPeratorResult = !(intA == intB);
            Console.WriteLine("logicalNorOPeratorResult: " + logicalNorOPeratorResult); //False

            Console.ReadLine();
        }
    }
}
