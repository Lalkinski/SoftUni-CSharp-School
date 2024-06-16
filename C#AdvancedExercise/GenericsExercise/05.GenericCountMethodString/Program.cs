namespace _05.GenericCountMethodString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Box<string> box = new Box<string>();    

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                box.Items.Add(input);
            }

            string value = Console.ReadLine();

            int result = box.Count(value);

            Console.WriteLine(result);
        }
    }
}
