namespace _06._Even_and_Odd_Subtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                if(currentNumber % 2 == 0)
                {
                    evenSum += currentNumber;
                }
                else if(currentNumber % 2 == 1)
                {
                    oddSum += currentNumber;
                }
            }

            int result = evenSum - oddSum;

            Console.WriteLine(result);
        }
    }
}
