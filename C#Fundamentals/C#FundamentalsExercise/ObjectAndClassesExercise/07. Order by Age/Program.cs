using System.Xml.Linq;
using static _5._Teamwork_Projects.Program;

namespace _5._Teamwork_Projects
{
    internal class Program
    {
        public class Person
        {
            public string Name { get; set; }
            public string IdPerson { get; set; }
            public int Age { get; set; }

            public Person(string name, string id, int age)
            {
                Name = name;
                IdPerson = id;
                Age = age;
            }
        }
        static void Main(string[] args)
        {
            string input;

            List<Person> list = new List<Person>();
            while ((input = Console.ReadLine()) != "End")
            {
                string[] person = input.Split();
                string name = person[0];
                string id = person[1];
                int age = int.Parse(person[2]);

                Person people = new Person(name, id, age);

                list.Add(people);
            }

            List<Person> sortedPerson = list.OrderBy(x => x.Age).ToList();

            foreach (Person item in sortedPerson)
            {
                Console.WriteLine($"{item.Name} with ID: {item.IdPerson} is {item.Age} years old.");
            }
        }
    }
}