/*
 
1 7 6 2 19 23
8
   
 */

namespace _08._Magic_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int input = int.Parse(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] + arr[j] == input)
                    {
                        Console.WriteLine($"{arr[i]} {arr[j]}");

                    }
                }
            }
        }
    }
}
