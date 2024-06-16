/*
Liam
Noah
James
Paid
Oliver
Lucas
Logan
Tiana
End

Amelia
Thomas
Elias
End
 */
class Program
{
    static void Main()
    {
        Queue<string> queue = new Queue<string>();
        string command;
        while((command = Console.ReadLine()) != "End")
        {
            if(command == "Paid")
            {
                while(queue.Count > 0)
                {
                    string name = queue.Dequeue();
                    Console.WriteLine(name);
                }
                continue;
            }
            queue.Enqueue(command);
        }

        Console.WriteLine($"{queue.Count} people remaining.");
    }
}

