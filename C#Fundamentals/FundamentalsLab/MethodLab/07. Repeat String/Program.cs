namespace _7._Repeat_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int inputRepeat = int.Parse(Console.ReadLine());

            for (int i = 0; i < inputRepeat; i++)
            {
                repeatString(input);
            }
        }

        static void repeatString(string input)
        {
            Console.Write(input);
        }
    }
}
