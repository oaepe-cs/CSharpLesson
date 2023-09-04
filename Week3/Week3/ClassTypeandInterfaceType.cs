using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Week3
{
    class ClassTypeandInterfaceType
    {
        static void ClassTypeMain()
        {
            Student s1 = new Student();
            s1.GoToSchool();
            s1.StartClass();
            s1.Grade = "Grade 11";

            Student s2 = new Student("Mg Mg");
            s2.GoToSchool();
            s2.StartClass();

            Student s3 = s1;
            Console.WriteLine("Grade: " + s3.Grade);
            s3.Grade = "Grade 10";
            s3.GoToSchool();


            s3.Create();

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string FirstName;
        public string LastName;
    }

    public class Student : Person, IOperation
    {
        DateTime DateOfBirth;
        string FatherName;
        char Gender;
        public string Grade;

        public Student()
        {

        }

        public Student(string _name)
        {
            FirstName = _name;
        }

        public void GoToSchool()
        {
            Console.WriteLine(FirstName + " Go to school.");
        }

        public void StartClass()
        {
            Console.WriteLine("Class start at 9 am");
        }

        public void Create()
        {
            Console.WriteLine("Create Operation");
        }

        public void Read()
        {
            Console.WriteLine("Read Operation");
        }

        public void Update()
        {
            Console.WriteLine("Update Operation");
        }

        public void Delete()
        {
            Console.WriteLine("Delete Operation");
        }
    }

    public interface IOperation
    {
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
