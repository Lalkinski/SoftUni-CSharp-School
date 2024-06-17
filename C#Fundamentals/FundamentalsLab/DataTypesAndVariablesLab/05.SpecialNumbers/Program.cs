using System;

class SpecialNumberProgram
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            bool isSpecial = CheckSpecialNumber(i);
            Console.WriteLine(i + " -> " + isSpecial);
        }
    }

    static bool CheckSpecialNumber(int num)
    {
        int sumOfDigits = 0;

        int tempNum = num;
        while (tempNum > 0)
        {
            int lastDigit = tempNum % 10;
            sumOfDigits += lastDigit;
            tempNum /= 10;
        }

        return (sumOfDigits == 5 || sumOfDigits == 7 || sumOfDigits == 11);
    }
}