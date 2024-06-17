namespace _04._Word
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                .Split()
                .Where(s => s.Length % 2 == 0)
                .ToArray();

            foreach (string word in words)
            {
                Console.Write(word);
                Console.WriteLine();
            }
        }
    }
}
