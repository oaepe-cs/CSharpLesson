using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            sbyte age;
            age = 100;
            sbyte age1 = 10;
            Console.WriteLine(age);
            Console.ReadLine();
            byte b;
            b = 10;
            Console.WriteLine(b);
            Console.ReadLine();

            Console.WriteLine("sbyte: -128 to 128");

            Console.WriteLine("byte: 0 to 255");
            
            short shorts;
            shorts = 3500;
            Console.WriteLine("short: -32768 to 32767");
            
            ushort uShort;
            uShort = 65535;
            Console.WriteLine("ushort: 0 to 65,535");
            Console.WriteLine(uShort);

            Console.WriteLine("********************");
            Console.WriteLine("Enter Num1");
            int num1;
            num1 = int.Parse(Console.ReadLine());            
            Console.WriteLine("Number 1:" + num1);

            Console.WriteLine("Enter Num2");
            int num2;
            num2 = int.Parse(Console.ReadLine());            
            Console.WriteLine("Number 2:" + num2);            

            int sum;
            sum = num1 + num2;
            Console.WriteLine("Sum: " + sum);
            int sub = num1 - num2;
            Console.WriteLine("Sub: " + sub);
            int mul = num1 * num2;
            Console.WriteLine("Mul: " + mul);
            int div = (num1 / num2);
            Console.WriteLine("Result: " + div);


            

            // + - * /
            Console.ReadLine();            
        }
    }
}
