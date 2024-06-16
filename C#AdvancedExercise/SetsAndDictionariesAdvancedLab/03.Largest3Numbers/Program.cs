class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray(); 

        int[] sorted = numbers.OrderByDescending(x => x).ToArray();

        Console.Write(string.Join(" ", sorted.Take(3)));
    }
}

