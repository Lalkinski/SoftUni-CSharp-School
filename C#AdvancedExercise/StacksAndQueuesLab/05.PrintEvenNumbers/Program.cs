class Program
{
    static void Main()
    {
        List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
        
        Queue<int> evenNumbers = new Queue<int>();

        for (int i = 0; i < list.Count; i++)
        {
            if (list[i] % 2 == 0)
            {
                evenNumbers.Enqueue(list[i]);
            }
        }

        Console.WriteLine(string.Join(", ", evenNumbers));
    }
}

