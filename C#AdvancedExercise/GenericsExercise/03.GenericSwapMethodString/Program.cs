
namespace _03.GenericSwapMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Box<string> box = new Box<string>();

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();

                box.Items.Add(input);
            }

            int[] index = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int firstIndex = index[0];
            int secondIndex = index[1];

            box.Swap(box.Items, firstIndex, secondIndex);

            Console.WriteLine(box);
        }

        
    }
}
