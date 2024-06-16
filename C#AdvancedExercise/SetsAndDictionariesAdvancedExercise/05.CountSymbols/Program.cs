/*
SoftUni rocks

Did you know Math.Round rounds to the nearest even integer?
 */
class Program
{
    static void Main()
    {
        
        SortedDictionary<char, int> keyValuePairs = new SortedDictionary<char, int>();
        string input = Console.ReadLine();

        for (int i = 0; i < input.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(input[i]))
            {
                keyValuePairs.Add(input[i], 0);
            }

            keyValuePairs[input[i]]++;
        }

        foreach(var kvp in keyValuePairs)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}

