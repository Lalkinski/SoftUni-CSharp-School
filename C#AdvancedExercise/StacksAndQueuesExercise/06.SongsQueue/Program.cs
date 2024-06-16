/*
All Over Again, Watch Me
Play
Add Watch Me
Add Love Me Harder
Add Promises
Show
Play
Play
Play
Play

Wake Up, Senorita, Best Song Ever, I Know You
Add Best Song Ever
Add Up Wake
Show
Play
Play
Play
Play
Show
Play
Add Watch Me Whip
Play
 */
class Program
{
    static void Main()
    {
        Queue<string> songs = new Queue<string>(Console.ReadLine().Split(", "));
        while (true)
        {
            string[] command = Console.ReadLine().Split();
            string action = command[0];

            if (action == "Play")
            {
                songs.Dequeue();

                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

            }
            else if (action == "Add")
            {
                string songToAdd = string.Join(" ", command.Skip(1));
                if (songs.Contains(songToAdd))
                {
                    Console.WriteLine($"{songToAdd} is already contained!");
                }
                else
                {
                    songs.Enqueue(songToAdd);
                }
            }
            else if (action == "Show")
            {
                Console.WriteLine(string.Join(", ", songs));
            }
        }
    }
}

