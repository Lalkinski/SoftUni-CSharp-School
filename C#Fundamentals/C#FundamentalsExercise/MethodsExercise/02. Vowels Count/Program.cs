namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] vowelsChars = text.ToCharArray();


            int vowelsSum = vowelsCharsMethod(text, vowelsChars);

            Console.WriteLine(vowelsSum);

        }
        private static int vowelsCharsMethod(string text, char[] vowelsChars)
        {
            int sum = 0;
            
            foreach (char letter in vowelsChars)
            {
                if (letter == 'a' || letter == 'A')
                {
                    sum++;
                }
                else if (letter == 'e' || letter == 'E')
                {
                    sum++;
                }
                else if (letter == 'o' || letter == 'O')
                {
                    sum++;
                }
                else if (letter == 'i' || letter == 'I')
                {
                    sum++;
                }
                else if (letter == 'u' || letter == 'U')
                {
                    sum++;
                }
                else if (letter == 'y' || letter == 'Y')
                {
                    sum++;
                }
            }

            return sum;
        }
    }
}
