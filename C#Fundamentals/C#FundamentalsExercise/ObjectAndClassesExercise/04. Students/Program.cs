using System.Diagnostics;
using static _04._Students.Program;
/*
4
Lakia Eason 3.90
Prince Messing 5.49
Akiko Segers 4.85
Rocco Erben 6.00

 
 */
namespace _04._Students
{
    internal class Program
    {
        public class Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public double Grade { get; set; }

            public Student(string firstName, string lastName, double grade)
            {
                FirstName = firstName;
                LastName = lastName;
                Grade = grade;
            }

        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> persons = new List<string>();
            
            List<Student> students = new List<Student>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string firstName = input[0];
                string lastName = input[1];
                double grade = double.Parse(input[2]);

                Student student = new Student(firstName, lastName, grade);

                students.Add(student);
            }

            List<Student> sortedStudents = students.OrderByDescending(s => s.Grade).ToList();


            foreach (Student student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }
        }
    }
}
