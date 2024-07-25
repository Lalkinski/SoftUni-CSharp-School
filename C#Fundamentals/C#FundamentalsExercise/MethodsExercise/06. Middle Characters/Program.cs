
using System;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        string middle = GetMiddle(input);
        Console.WriteLine(middle);
    }

    static string GetMiddle(string input)
    {
        int length = input.Length;
        int middleIndex = length / 2;

        if (length % 2 == 0) 
        {
            return input.Substring(middleIndex - 1, 2);
        }
        else 
        {
            return input.Substring(middleIndex, 1);
        }
    }
}
