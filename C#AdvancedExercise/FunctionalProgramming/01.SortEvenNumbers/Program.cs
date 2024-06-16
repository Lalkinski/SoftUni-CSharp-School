/*
4, 2, 1, 3, 5, 7, 1, 4, 2, 12

1, 3, 5

2, 4, 6
 */
class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .Where(x => x % 2 == 0)
            .OrderBy(x => x)
            .ToList();

        Console.WriteLine(string.Join(", ", numbers));
    }
}

