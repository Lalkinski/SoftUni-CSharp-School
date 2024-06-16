class Program
{
    static void Main()
    {
        string input = Console.ReadLine();

        Stack<int> brackets = new Stack<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i] == '(')
            {
                brackets.Push(i);
            }
            else if (input[i] == ')')
            {
                int startIndex = brackets.Pop();
                int endIndex = i;

                string substring = input.Substring(startIndex, endIndex - startIndex + 1);
                Console.WriteLine(substring);
            }
        }
    }
}

