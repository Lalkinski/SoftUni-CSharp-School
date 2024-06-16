/*
Lucas Noah Tea

Teo Lucas Harry

Ashurbanipal Napoleon Caeser
 */
class Program
{
    static void Main()
    {
        string[] names = Console.ReadLine().Split();

        Action<string[]> printer = name =>
        {
            Console.WriteLine(string.Join(Environment.NewLine, names));
        };

        printer(names);
    }
}

