namespace _03._Rounding_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            foreach (double n in numbers)
            {
                Console.WriteLine($"{n} => {(int)Math.Round(n, MidpointRounding.AwayFromZero)}");
            }
        }
    }
}