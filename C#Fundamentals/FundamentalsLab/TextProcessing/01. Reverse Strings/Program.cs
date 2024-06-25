/*
helLo
Softuni
bottle
end
 */
namespace _01._Reverse_Strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line;
            string reversed = string.Empty;
            while((line = Console.ReadLine()) != "end")
            {
                for (int i = line.Length - 1; i >= 0; i--)
                {
                    reversed += line[i];
                }
                Console.WriteLine($"{line} = {reversed}");
                reversed = string.Empty;
            }

        }
    }
}
