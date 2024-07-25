using System;
using System.Text.RegularExpressions;

public class Example
{
    class Racer
    {
        public string Name { get; set; }
    }
    public static void Main()
    {
        string pattern = @"([A-Za-z])";
        string[] input = Console.ReadLine().Split(", ").ToArray();

        string encryptedMessage;
        while((encryptedMessage = Console.ReadLine()) != "end of race")
        {
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(encryptedMessage, pattern, options))
            {
                Racer racer = new Racer();

            }

        }
    }
}
