class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();

        Action<string[]> printer = name =>
        {
            Console.WriteLine(
                string.Join(
                    Environment.NewLine, 
                    name.Select(name => "Sir " + name)));
        };

        printer(names);
    }
}

