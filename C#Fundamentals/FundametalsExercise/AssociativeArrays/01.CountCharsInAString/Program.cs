namespace _1._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();


            Dictionary<char, int> counts = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if(symbol == ' ')
                {
                    continue;
                }

                if (!counts.ContainsKey(symbol))
                {
                    counts.Add(symbol, 0);
                }

                counts[symbol]++;
            }

            foreach(var output in counts)
            {
                char letter = output.Key;
                int countOfLetter = output.Value;

                Console.WriteLine($"{letter} -> {countOfLetter}");
            }
        }
    }
}
