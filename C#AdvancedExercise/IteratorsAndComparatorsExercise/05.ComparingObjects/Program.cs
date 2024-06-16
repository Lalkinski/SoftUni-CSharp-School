namespace _05.ComparingObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();

            string input = Console.ReadLine();
            while(input != "END")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];


                Person person = new Person(name, age, town);

                people.Add(person);

                input = Console.ReadLine();
            }

            int n = int.Parse(Console.ReadLine());

            Person personCompare = people[n - 1];

            int equalPerson = people.Count(person => person.CompareTo(personCompare) == 0);

            if(equalPerson > 1)
            {
                Console.WriteLine($"{equalPerson} {people.Count - equalPerson} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }

            //5 - 2 = 3
        }
    }
}
