/*
Programming Fundamentals : John Smith
Programming Fundamentals : Linda Johnson
JS Core : Will Wilson
Java Advanced : Harrison White
end
 */
using _5._Courses;
using System.Reflection.Metadata.Ecma335;

namespace _5._Courses
{
    public class Course
    {

        public Course(string name)
        {
            Name = name;
            StudentName = new List<string>();
        }
        public string Name { get; set; }
        public List<string> StudentName { get; set; }

        public override string ToString()
        {
            string result = $"{Name}: {StudentName.Count}\n";

            for (int i = 0; i < StudentName.Count; i++)
            {
                result += $"-- {StudentName[i]}\n";
            } 
            
            return result.Trim();
        }
    }
 }    

    
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Course> courseMap = new Dictionary<string, Course>();

            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string[] arguments = input.Split(" : ");

                string courseName = arguments[0];   
                string studentName = arguments[1];
                
                if(!courseMap.ContainsKey(courseName))
                {
                    Course newCourse = new Course(courseName);
                    courseMap.Add(courseName, newCourse);
                }

                courseMap[courseName].StudentName.Add(studentName);
            }

            foreach(Course course in courseMap.Values)
            {
                Console.WriteLine(course);
            }
        }
    }

