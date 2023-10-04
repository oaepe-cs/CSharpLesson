using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aseembly1;
using Aseembly1.Model;
using System.IO;

namespace Week7
{
    class Program
    {
        static void ProgramMain(string[] args)
        {
            Circle _circleObj = new Circle();
            float _result = _circleObj.GetArea();
            Console.WriteLine("Result: " + _result);

            Square _squale = new Square();
            float result = _squale.GetArea();
            Console.WriteLine("Result: " + result);

            Animal animalObj = new Animal("Cat");
            animalObj.Eat("fish");

            Dog dogObj = new Dog("Aung Net");
            dogObj.Eat("Rice");


            Horse horseObj = new Horse("Jhonny");
            horseObj.Eat("Grass");

            Bird birdObject = new Bird("Bird");
            birdObject.Eat("Fruit");

            FlyingHorse flyHorseObj = new FlyingHorse();
            flyHorseObj.Run();
            flyHorseObj.Fly();
            Console.WriteLine("Count of legs: " + flyHorseObj.GetCountOfLegs());
            Console.WriteLine("Count of Wings: " + flyHorseObj.GetCountOfWings());

            using (var uObj = new DestractorClass())
            {

            }

            ReadFile();
            using (FileStream fs = new FileStream("test.txt", FileMode.Append))
            {
                using (var streamWriter = new StreamWriter(fs))
                {
                    streamWriter.WriteLine("six");
                }
            }

            ReadFile();
            Console.ReadLine();
        }

        private static void ReadFile()
        {
            using (FileStream fs = new FileStream("test.txt", FileMode.Open))
            {
                using (var streamReader = new StreamReader(fs))
                {
                    string line = "";
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
        }
    }
}
