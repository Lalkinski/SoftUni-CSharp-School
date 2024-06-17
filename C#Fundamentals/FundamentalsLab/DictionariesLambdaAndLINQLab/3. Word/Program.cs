namespace _3._Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> result = new Dictionary<string, List<string>>();   

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if (!result.ContainsKey(word))
                {
                    result[word] = new List<string>();
                }

                result[word].Add(synonym);
            }

            foreach(KeyValuePair<string, List<string>> kvp in result)
            {
                Console.WriteLine($"{kvp.Key} - {string.Join(", ", kvp.Value)}");
            }
        }
    }
}
