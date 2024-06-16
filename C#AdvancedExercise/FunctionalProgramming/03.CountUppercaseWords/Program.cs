/*
The following example shows how to use Function

Write a program that reads one line of text from console. Print count of words that start with Uppercase, after that print all those words in the same order like you find them in text.
 */
class Program
{
    static void Main()
    {
        Predicate<string> checker = n => n[0] == n.ToUpper()[0];
        string[] words = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Where(w => checker(w))
            .ToArray();

        foreach(string word in words)
        {
            Console.WriteLine(word);
        }



    }
}

