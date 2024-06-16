/*
9
1 97
2
1 20
2
1 26
1 20
3
1 91
4

9
1 47
1 66
1 32
4
3
1 25
1 16
1 8
4
 */
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            string[] action = Console.ReadLine().Split(' ');
            string command = action[0];
            switch (command)
            {
                case "1":
                    int numberToAdd = int.Parse(action[1]);
                    stack.Push(numberToAdd);
                    break;
                case "2":
                    if(stack.Count == 0)
                    {
                        continue;
                    }
                    stack.Pop();
                    break;
                case "3":
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    int biggestNumber = int.MinValue;
                    foreach (int number in stack)
                    {
                        if (number > biggestNumber)
                        {
                            biggestNumber = number;
                        }
                    }

                    Console.WriteLine(biggestNumber);
                    break;
                case "4":
                    if (stack.Count == 0)
                    {
                        continue;
                    }
                    int smallestNumber = int.MaxValue;
                    foreach (int number in stack)
                    {
                        if (number < smallestNumber)
                        {
                            smallestNumber = number;
                        }
                    }

                    Console.WriteLine(smallestNumber);
                    break;
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}

