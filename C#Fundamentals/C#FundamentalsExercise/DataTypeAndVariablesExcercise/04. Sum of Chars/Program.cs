namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int symbolCount = int.Parse(Console.ReadLine());

            int sum = 0;

            for (int i = 0; i < symbolCount; i++)
            {
                char c = char.Parse(Console.ReadLine());
                sum += c;
            }

            Console.WriteLine($"The sum equals: {sum}");

        }
    }
}
