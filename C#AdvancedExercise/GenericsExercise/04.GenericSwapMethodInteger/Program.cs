namespace _04.GenericSwapMethodInteger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<int> box = new Box<int>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

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
