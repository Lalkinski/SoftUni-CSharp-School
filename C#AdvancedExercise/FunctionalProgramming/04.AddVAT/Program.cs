/*
1.38, 2.56, 4.4

1, 3, 5, 7
 */
class Program
{
    static void Main()
    {
        double[] prices = Console.ReadLine()
            .Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .Select(n => n * 1.2)
            .ToArray();

        foreach(var price in prices)
        {
            Console.WriteLine($"{price:f2}");
        }
    }
}

