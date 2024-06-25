namespace _03._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filter = Console.ReadLine();
            string text = Console.ReadLine();
            while (text.Contains(filter))
            {
                int statingIndex = text.IndexOf(filter);
                text = text.Remove(statingIndex, filter.Length);
            }

                Console.WriteLine(text);
        }
    }
}
 