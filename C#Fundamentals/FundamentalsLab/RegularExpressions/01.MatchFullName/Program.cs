using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+";
        string names = Console.ReadLine();

        MatchCollection matchedNames = Regex.Matches(names, pattern);

        foreach (Match match in matchedNames)
        {
            Console.Write(match.Value + " ");
        }
        Console.WriteLine();
    }
}
