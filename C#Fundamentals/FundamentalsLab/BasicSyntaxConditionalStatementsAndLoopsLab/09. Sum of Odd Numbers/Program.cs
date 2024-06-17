//namespace _09._Sum_of_Odd_Numbers
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            int number = int.Parse(Console.ReadLine());
//            int sum = 0;
//            if (number < 1 || number > 100)
//            {
//                Console.WriteLine("Invalid input. n should be in the interval [1…100].");
//                return;
//            }

//            for (int i = 1; i <= number; i++)
//            {
//                int oddNUmber = 2 * 1 - 1;
//                Console.WriteLine(oddNUmber);
//                sum += oddNUmber;
//            }

//            Console.WriteLine($"Sum: {sum}");
//        }
//    }
//}
using System;

class Program
{
    static void Main()
    {
        
        int n = int.Parse(Console.ReadLine());

        if (n < 1 || n > 100)
        {
           
            return;
        }

       
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            int oddNumber = 2 * i - 1;
            Console.WriteLine(oddNumber);
            sum += oddNumber;
        }

       
        Console.WriteLine($"Sum: {sum}");
    }
}