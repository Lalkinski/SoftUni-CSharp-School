using System;
using System.Text.RegularExpressions;

public class Example
{
    public static void Main()
    {
        string pattern = @"(?<day>\d{2})([/|(-|.])(?<month>[A-Z]{1}[a-z]+)\1(?<year>\d{4})";
        string input = Console.ReadLine();

        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            var day = m.Groups["day"].Value;
            var month = m.Groups["month"].Value;
            var year = m.Groups["year"].Value;

            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}
