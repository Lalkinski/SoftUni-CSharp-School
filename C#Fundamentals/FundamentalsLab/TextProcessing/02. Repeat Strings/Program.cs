using System.Text;

namespace _02._Repeat_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] word = Console.ReadLine().Split();

            StringBuilder sb = new StringBuilder();

            foreach (string s in word)
            {
                int count = s.Length;

                for (int i = 0; i < count; i++)
                {
                    sb.Append(s);
                }

            }
                Console.WriteLine(sb);
        }
    }
}
