namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person("Mario", 18);

            Console.WriteLine(person.Name);
            Console.WriteLine(person.Age);
        }
    }
}