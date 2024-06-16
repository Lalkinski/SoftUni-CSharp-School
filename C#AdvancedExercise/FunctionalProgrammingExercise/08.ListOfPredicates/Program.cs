class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<int> numbers = Enumerable.Range(1, n).ToList(); 

        int[] dividers = Console.ReadLine() 
            .Split()
            .Select(int.Parse)
            .ToArray();

        Func<int, int[], bool> isDivisible = (number, divs)
            => divs.All(x => number % x == 0);

        int[] result = numbers
            .Where(number => isDivisible(number, dividers))
            .ToArray();

        Console.WriteLine(string.Join(" ", result));
    }
}
