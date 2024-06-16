class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>(Console.ReadLine().Split(' '));
        int n = int.Parse(Console.ReadLine());

        int moves = 1;
        while(queue.Count != 1)
        {
            string childToPlay = queue.Dequeue();
            if(moves == n)
            {
                Console.WriteLine($"Removed {childToPlay}");
                moves = 0;
            }
            else
            {
                queue.Enqueue(childToPlay);
            }

            moves++;
        }

        Console.WriteLine($"Last is {queue.Dequeue()}");
    }
}

