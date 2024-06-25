using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string regex = @"\+359([ |-])[2]\1\d{3}\1\d{4}(?!\d)";
        var phones = Console.ReadLine();
        var phoneMatches = Regex.Matches(phones, regex);
        List<string> mathechPhones = phoneMatches
            .Cast<Match>()
            .Select(a => a.Value.Trim())
            .ToList();

        Console.WriteLine(string.Join(", ", mathechPhones));
    }
}
