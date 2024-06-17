using System;

class Program
{
    static void Main()
    {
        char inputChar;

        inputChar = Console.ReadLine()[0];

        if (char.IsUpper(inputChar))
        {
            Console.WriteLine("\nupper-case");
        }
        else if (char.IsLower(inputChar))
        {
            Console.WriteLine("\nlower-case");
        }
       
    }
}