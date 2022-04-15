using System;
using System.Collections.Generic;
using System.Linq;

namespace HW15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var classes = new[]
           {
               new Classroom { Students = {"Evgeniy", "Sergey", "Andrew"}, },
               new Classroom { Students = {"Anna", "Viktor", "Vladimir"}, },
               new Classroom { Students = {"Bulat", "Alex", "Galina"}, }
           };
            var allStudents = GetAllStudents(classes);

            Console.WriteLine(string.Join(" ", allStudents));
        
    }

        private static string[] GetAllStudents(Classroom[] classes)
        {
            var s = (from classroom in classes
                     from student in classroom.Students
                     select student).ToArray();
            return s;
        }

    }

    internal class Classroom
    {
        public List<string> Students = new List<string>();
    }
}
