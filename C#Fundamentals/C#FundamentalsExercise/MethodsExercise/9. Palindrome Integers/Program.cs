namespace _9._Palindrome_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                bool isPalindrom = isNumberPalindrom(command);
                Console.WriteLine(isPalindrom);
            }
        }

        private static bool isNumberPalindrom(string command)
        {
            //121 - 1
            string firstHalf = command.Substring(0, command.Length / 2);

            //[1, 2, 1]
            char[] charArr = command.ToCharArray();

            //[1, 2, 1]
            Array.Reverse(charArr);

            string reversed = new string(charArr);

            //1
            string lastHalf = reversed.Substring(0, reversed.Length / 2);

            //1 == 1
            bool isEqual = firstHalf == lastHalf;

            return isEqual;

        }
    }
}
