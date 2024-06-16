class Program
{
    static void Main()
    {
        Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();

        string[] input = Console.ReadLine().Split();

        for (int i = 0; i < input.Length; i++)
        {
            if (!keyValuePairs.ContainsKey(input[i]))
            {
                keyValuePairs.Add(input[i], 0);
            }

            keyValuePairs[input[i]]++;
        }

        foreach (var item in keyValuePairs)
        {
            Console.WriteLine($"{item.Key} - {item.Value} times");
        }

    }
}

