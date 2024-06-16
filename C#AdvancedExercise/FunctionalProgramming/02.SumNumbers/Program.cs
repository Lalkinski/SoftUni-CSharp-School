/*
4, 2, 1, 3, 5, 7, 1, 4, 2, 12

2, 4, 6
 */
class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split(", ")
            .Select(int.Parse)
            .ToList();

        int sum = numbers.Sum();

        Console.WriteLine(numbers.Count);
        Console.WriteLine(sum);
    }
}

