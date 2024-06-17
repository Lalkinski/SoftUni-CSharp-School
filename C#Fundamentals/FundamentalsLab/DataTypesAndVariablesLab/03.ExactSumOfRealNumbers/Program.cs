/*
3
1000000000000000000
5
10
 
2
0.00000000003
333333333333.3
 */

namespace Exact_Sum_of_Real_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int numberCount = int.Parse(Console.ReadLine());

            decimal sum = 0;

            for (int i = 0; i < numberCount; i++)
            {
                decimal number = decimal.Parse(Console.ReadLine()); 

                sum += number;
            }

            Console.WriteLine(sum);

        }
    }
}
