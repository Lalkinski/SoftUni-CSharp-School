using System.Collections.Generic;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char startSymbol = char.Parse(Console.ReadLine());
            char endSymbol = char.Parse(Console.ReadLine());

            if (startSymbol > endSymbol)
            {
                char swapTemp = startSymbol;
                startSymbol = endSymbol;
                endSymbol = swapTemp;
            }

            printBetweenLetter(startSymbol, endSymbol);
        }

        private static void printBetweenLetter(char startSymbol, char endSymbol)
        {
            for (int i = startSymbol + 1; i < endSymbol; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}

