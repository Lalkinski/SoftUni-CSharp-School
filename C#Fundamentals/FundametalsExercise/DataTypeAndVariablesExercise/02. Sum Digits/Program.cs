/*
 
myint.ToString().Length

 */

using System;

namespace _02._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int numberCopy = number;

            int sum = 0;

            number = Math.Abs(number);

            foreach (char digitChar in number.ToString())
            {
                sum += int.Parse(digitChar.ToString());
            }

            Console.WriteLine(sum);
        }
    }
}
