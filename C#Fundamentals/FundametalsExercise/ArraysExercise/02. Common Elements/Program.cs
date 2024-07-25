using System;


internal class Program
{
    static void Main()
    {
        string[] firstArray = Console.ReadLine().Split();
        string[] secondArray = Console.ReadLine().Split();

         for (int i = 0; i < secondArray.Length; i++)
         {
            for (int j = 0; j < firstArray.Length; j++)
            {
                if (firstArray[i] == secondArray[j])
                {
                    Console.Write($"{firstArray[i]} ");
                    break;
                }
            }
         }
    }
}