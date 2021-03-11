using System;
using System.Collections.Generic;

namespace GenericsExercise.Console
{
    public class Program
    {
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
            // code here
            throw new NotImplementedException();
        }

        static public void InsertUniversity(string id, string name, string address)
        {
            // code here
            throw new NotImplementedException();
        }

        static public IEnumerable<Student> GetAllStudents()
        {
            // code here
            throw new NotImplementedException();
        }

        static public IEnumerable<University> GetAllUniversities()
        {
            // code here
            throw new NotImplementedException();
        }
    }
}