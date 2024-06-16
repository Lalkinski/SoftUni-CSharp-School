/*
5 2 13
1 13 45 32 4

4 1 666
420 69 13 666

3 3 90
90 90 90
 */
class Program
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int N = int.Parse(input[0]);
        int S = int.Parse(input[1]);
        int X = int.Parse(input[3]);

        string[] elements = Console.ReadLine().Split();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < N; i++)
        {
            int element = int.Parse(elements[i]);
            stack.Push(element);
        }

        for (int i = 0;i < S; i++)
        {
            if(stack.Count > 0)
            {
                stack.Pop();
            }
        }

        if (stack.Contains(X))
        {
            Console.WriteLine("true");
        }
        else
        {
            if(stack.Count == 0)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallestNumber = int.MaxValue;
                foreach(int element in stack)
                {
                    if(element < smallestNumber)
                    {
                        smallestNumber = element;
                    }
                }

                Console.WriteLine(smallestNumber);
            }
        }
    }
}

