using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week2
{
    class Operators
    {
        static void Main3()
        {
            //Addition (+)
            int num1 = 10;
            int num2 = 20;
            int result = num1 + num2;
            Console.WriteLine("Addition (+)");
            Console.WriteLine(result);

            //Substraction (-)
            num1 = 50;
            num2 = 20;
            result = num1 - num2;
            Console.WriteLine("Substraction (-)");
            Console.WriteLine(result);

            //Multiplication
            result = num1 * num2;
            Console.WriteLine("Multiplication (*)");
            Console.WriteLine(result);

            //Division
            result = num1 / num2;
            Console.WriteLine("Division (/)");
            Console.WriteLine(result);

            //Modulus (%)
            result = num1 % num2;
            Console.WriteLine("Modulus (%)");
            Console.WriteLine(result);

            //Increment (++)
            int tempResult = result;
            Console.WriteLine("Temp Result: " + tempResult);
            result++;
            Console.WriteLine("Increment (++)");
            Console.WriteLine(result);
            tempResult = tempResult + 1;
            Console.WriteLine("After increment, Temp Result: " + tempResult);
            
            //Decrement (--)
            result--;
            tempResult = tempResult - 1;
            Console.WriteLine("Decrement (--)");
            Console.WriteLine(result);
            Console.WriteLine("After decremet, Temp Result: "+ tempResult);
            

            //Order of precedence (*/, +-) 
            //left to right
            //()
            Console.WriteLine("Order of precedence (*/, +-)");
            int sum = (5 - 10) * (3 + 20);
            Console.WriteLine(sum);





            Console.ReadLine();
        }
    }
}
