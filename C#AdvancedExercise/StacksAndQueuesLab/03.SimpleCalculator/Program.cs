class Program
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        Stack<string> stack = new Stack<string>();

        for (int i = 0; i < input.Length; i++)
        {
            stack.Push(input[i]);
        }

        int result = 0;
        while(stack.Count > 0)
        {
            int lastNumber = int.Parse(stack.Pop());

            if(stack.Count == 0)
            {
                result += lastNumber;
                break;
            }
            char operation = char.Parse(stack.Pop());

            if(operation == '+')
            {
                result += lastNumber;
            }
            else if(operation == '-')
            {
                result -= lastNumber;
            }
        }

        Console.WriteLine(result);
    }
}


