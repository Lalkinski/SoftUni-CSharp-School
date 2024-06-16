/*
I Love C#

Stacks and Queues
 */
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        
        Stack<char> chard = new Stack<char>();

        for (int i = 0; i < input.Length; i++)
        {
            chard.Push(input[i]);
        }

        while (chard.Count > 0)
        {
            Console.Write(chard.Pop());
        }
    }
}

