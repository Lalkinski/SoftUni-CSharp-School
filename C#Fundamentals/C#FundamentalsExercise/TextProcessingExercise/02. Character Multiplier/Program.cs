
namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            int calculate = Calculate(input[0], input[1]);

            Console.WriteLine(calculate);
        }

        static int Calculate(string word1, string word2)
        {
            int m = Math.Min(word1.Length, word2.Length);

            int result = 0;
            for (int i = 0; i < m; i++)
            {
                result += word1[i] * word2[i];
            }

            for (int i = m; i < word1.Length; i++)
            {
                result += word1[i];
            }

            for (int i = m; i < word2.Length; i++)
            {
                result += word2[i];
            }

            return result;
        }
    }
}
