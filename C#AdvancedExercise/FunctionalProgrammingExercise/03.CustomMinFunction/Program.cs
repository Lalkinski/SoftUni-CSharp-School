class Program
{
    static void Main()
    {
        //1 4 3 2 1 7 13 - input
        //1 - output
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Func<int[], int> smallestNumber = number => number.Min();

        Console.WriteLine(smallestNumber(numbers));
    }
}
