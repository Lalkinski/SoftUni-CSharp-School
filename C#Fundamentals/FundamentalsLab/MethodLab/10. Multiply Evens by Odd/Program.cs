
namespace _10._Multiply_Evens_by_Odd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;
            int result = 0;

            for (int i = 0; i < number; i++)
            {
                if(i % 2 == 0)
                {
                    evenSum = i;
                }
                if(i % 2 == 1)
                {
                    oddSum = i;
                }
            }

            oddSum = evenSum * oddSum;

            Console.WriteLine(oddSum);
        }
        static void GetMultipleOfEvenAndOdds(int number, int result, int evenSum, int oddSum)
        {
            //result
            result = evenSum * oddSum;
        }

        static void GetSumOfEvenDigits(int number, int evenSum)
        {
            //even 
            for (int i = 0; i < number; i++)
            {
                if(i % 2 == 0)
                {
                    evenSum += i; 
                }
            }
        }

        static void GetSumOfOddDigits(int number, int oddSum)
        {
            for (int i = 0; i < number; i++)
            {
                if (i % 2 == 1)
                {
                    oddSum += i;
                }
            }
        }

        
    }
}
