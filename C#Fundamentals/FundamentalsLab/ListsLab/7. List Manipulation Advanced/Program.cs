List<int> numbers = Console.ReadLine()
    .Split()
    .Select(int.Parse)
    .ToList();

string commands;
int sum = 0;
int counter = 0;

string[] arr;

while ((commands = Console.ReadLine()) != "end")
{
    string[] commandsTokens = commands.Split().ToArray();
    string command = commandsTokens[0];

    arr = commandsTokens;

    if (command == "Add")
    {
        int number = int.Parse(commandsTokens[1]);
        numbers.Add(number);
        counter++;
    }
    else if (command == "Remove")
    {
        int number = int.Parse(commandsTokens[1]);
        numbers.Remove(number);
        counter++;
    }
    else if (command == "RemoveAt")
    {
        int index = int.Parse(commandsTokens[1]);
        numbers.RemoveAt(index);
        counter++;
    }
    else if (command == "Insert")
    {
        int number = int.Parse(commandsTokens[1]);
        int index = int.Parse(commandsTokens[2]);
        numbers.Insert(index, number);
        counter++;
    }
    else if (command == "Contains")
    {
        int number = int.Parse(commandsTokens[1]);

        if (numbers.Contains(number))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }
    }
    else if (command == "PrintEven")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        Console.WriteLine();
    }
    else if (command == "PrintOdd")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            if (numbers[i] % 2 == 1 || numbers[i] % 2 == -1)
            {
                Console.Write(numbers[i] + " ");
            }
        }

        Console.WriteLine();
    }
    else if (command == "GetSum")
    {
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];

        }

        Console.WriteLine(sum);
    }
    else if (command == "Filter")
    {
        string condition = commandsTokens[1];
        int number = int.Parse(commandsTokens[2]);

        List<string> result = new List<string>();

        if (condition == "<")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < number)
                {
                    result.Add($"{numbers[i]}");
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }
        else if (condition == ">")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] > number)
                {
                    result.Add($"{numbers[i]}");
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }
        else if (condition == ">=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= number)
                {
                    result.Add($"{numbers[i]}");
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }
        else if (condition == "<=")
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= number)
                {
                    result.Add($"{numbers[i]}");
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i] + " ");
            }

            Console.WriteLine();
        }
    }
}

if (commands == "end" && counter > 0)
{
    Console.WriteLine(string.Join(" ", numbers));
}