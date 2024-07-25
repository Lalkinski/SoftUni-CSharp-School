using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder result = new StringBuilder(capacity: text.Length);

            int index = 0;
            while (index < text.Length)
            {
                while(index + 1 < text.Length && text[index] == text[index + 1]) index++;


                result.Append(text[index]);
                index++;
            }

            Console.WriteLine(result.ToString());
        }
    }
}
