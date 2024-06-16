/*
1 2 3 4
adD 5 6
REmove 3
eNd
 */
class Program
{
    static void Main(string[] args)
    {

        Stack<int> stack = new Stack<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());
        string command;
        while ((command = Console.ReadLine().ToLower()) != "end")
        {
            string[] tokens = command.Split(' ');
            string action = tokens[0].ToLower();
            if (action == "add")
            {
                int firstNumber = int.Parse(tokens[1]);
                int secondNumber = int.Parse(tokens[2]);

                stack.Push(firstNumber);
                stack.Push(secondNumber);
            }
            else
            {
                int count = int.Parse(tokens[1]);
                if (stack.Count > count)
                {
                    for (int i = 0; i < count; i++)
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    continue;
                }
            }
        }

        int sum = 0;
        foreach (int i in stack)
        {
            sum += i;
        }
        Console.WriteLine($"Sum: {sum}");
    }
}

