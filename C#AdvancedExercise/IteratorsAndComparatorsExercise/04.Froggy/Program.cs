namespace _04.Froggy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1, 2, 3, 4, 5, 6, 7, 8

            List<int> stones = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToList();

            Lake lake = new Lake(stones);

            Console.WriteLine(string.Join(", ", lake));
        }
    }
}
