using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericsExercise.Console
{
    public class Program
    {
        private readonly Persistence persistence;

        public Program()
        {
            persistence = new Persistence();
        }

        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

            System.Console.WriteLine();
            System.Console.WriteLine("Inserting some students!");

            InsertStudent("mirel", "Mirel", "Testache");
            InsertStudent("costel", "Costel", "Testache");
            InsertStudent("sandel", "Sandel", "Testache");
            InsertStudent("gigel", "Gigel", "Testache");

            System.Console.WriteLine("Reading students:");

            var students = GetAllStudents();
            foreach(var student in students)
            {
                System.Console.WriteLine(student.Id);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Inserting some universities!");

            InsertUniversity("UAIC", "A. I. Cuza", "Iasi");
            InsertUniversity("uni%BUC%", "University of Bucharest", "Bucuresti");

            System.Console.WriteLine("Reading universities:");

            var universities = GetAllUniversities();
            foreach (var university in universities)
            {
                System.Console.WriteLine(university.Id);
            }

            System.Console.WriteLine();
            System.Console.WriteLine("Done!");
        }

        static public void InsertStudent(string id, string firstName, string lastName)
        {
            throw new NotImplementedException();
        }

        static public void InsertUniversity(string id, string name, string address)
        {
            throw new NotImplementedException();
        }

        static public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        static public IEnumerable<University> GetAllUniversities()
        {
            throw new NotImplementedException();
        }
    }

    public class Student : IEntity
    {
        public string Id { get; set; }

        public string FisrtName { get; set; }
        public string LastName { get; set; }
    }

    public class University : IEntity
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
    }
}
