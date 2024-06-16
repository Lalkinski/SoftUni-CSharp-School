namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            Person person = new Person();

            Dictionary<string, int> peoples = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);

                if (age > 30)
                {
                    person.Name = name;
                    person.Age = age;
                    
                    peoples.Add(person.Name, person.Age);
                }
            }

            var people = peoples.OrderBy(x => x.Key);

            foreach (var item in people)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }
    }
}