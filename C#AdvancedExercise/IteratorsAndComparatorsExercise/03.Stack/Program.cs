/*
Push 1, 2, 3, 4
Pop
Pop
Pop
Pop
Pop
END

 */
namespace _03.Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] token = command.Split(
                    new[] { ' ', ',' },
                    StringSplitOptions.RemoveEmptyEntries);

                if (token[0] == "Push")
                {
                    int[] numbers = token
                        .Skip(1)
                        .Select(int.Parse)
                        .ToArray();

                    foreach (var item in numbers)
                    {
                        stack.Push(item);
                    }
                }
                else if (token[0] == "Pop")
                {
                    if (stack.Count == 0)
                    {
                        Console.WriteLine("No Elements");
                    }
                    else
                    {
                        stack.Pop();
                    }
                }

                command = Console.ReadLine();
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
