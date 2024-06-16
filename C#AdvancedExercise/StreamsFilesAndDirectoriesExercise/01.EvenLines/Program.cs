namespace EvenLines
{
    using System;
    using System.Text;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            using var reader = new StreamReader(inputFilePath);

            int counter = 0;

            StringBuilder stringBuilder = new StringBuilder();

            while (true)
            {
                string line = reader.ReadLine();

                if (line == null)
                {
                    break;
                }

                if (counter % 2 == 0)
                {
                    string[] words = line.Split().Reverse().ToArray();
                    string text = string.Join(" ", words);

                    stringBuilder.AppendLine(text);
                }

                counter++;
            }

            char[] elements = { '-', ',', '.', '!', '?' };
            foreach (char c in elements)
            {
                stringBuilder = stringBuilder.Replace(c, '@');
            }

            return stringBuilder.ToString().TrimEnd();
        }
    }
}
