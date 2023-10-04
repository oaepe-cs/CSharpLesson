using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ListExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();

            Exercise2();
            Console.ReadLine();
        }

        private static void Exercise1()
        {
            List<Dog> lstDog = new List<Dog>();
            Dog d1 = new Dog
            {
                Name = "AungNet", Color= Color.White.ToString()
            };
            lstDog.Add(d1);
            Dog d2 = d1;
            lstDog.Add(d2);            
            lstDog.Add(d2);

            Dog d4 = new Dog
            {
                Name = "Phoe Phyu",
                Color = Color.Black.ToString()
            };
            lstDog.Add(d4);
            lstDog.Add(d4);
            Console.WriteLine("total dogs: " + lstDog.Count);
            Console.WriteLine("total whight dogs: " + lstDog.Where(x=>x.Color==Color.White.ToString()).Count());
            Console.WriteLine("total black dogs: " + lstDog.Where(x => x.Color == Color.Black.ToString()).Count());
            lstDog.RemoveAt(0);
            Console.WriteLine("After Removed");
            Console.WriteLine("total dogs: " + lstDog.Count);
            Console.WriteLine("total whight dogs: " + lstDog.Where(x => x.Color == Color.White.ToString()).Count());
            Console.WriteLine("total black dogs: " + lstDog.Where(x => x.Color == Color.Black.ToString()).Count());
        }

        private static void Exercise2()
        {
            List<Book> lstBook = new List<Book>();
            Book b1 = new Book
            {
                Name = "Introduction of Computer",
                price = 10
            };
            lstBook.Add(b1);
            Book b2 = new Book
            {
                Name = "novel",
                price = 10
            };
            lstBook.Add(b2);
            Book b3 = new Book
            {
                Name = "Computer Network",
                price = 50
            };
            lstBook.Add(b3);

            decimal total = 0;
            foreach (var item in lstBook)
            {
                if(item.Name.ToLower().Contains("computer"))
                {
                    total += item.price;
                    total = total + item.price;                    
                }
            }

            Console.WriteLine("total Price book contain with computer: " + total);
        }
    }

    internal class Book
    {
        internal string Name;
        internal decimal price;
    }

    enum Color
    {
        White,
        Black,
        Gray,
        Brown
    }

    class Dog
    {
        internal string Name;
        internal string Color;
    }
}
