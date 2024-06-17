namespace _12._Even_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int number = int.Parse(Console.ReadLine());
                if(number % 2 != 0)
                {
                    Console.WriteLine("Please write an even number.");
                }
                else
                {
                    number = Math.Abs(number);
                    Console.WriteLine($"The number is: {number}");
                    break;
                }
            }
        }
    }
}