/*
1 2 3 4 5
add
add
print
end

5 10
multiply
subtract
print
end

 */
class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Func<int[], string, int[]> appliedArithmetics = (number, command) =>
        {
            return command == "add"
                ? number.Select(x => x + 1).ToArray()
                : command == "multiply"
                    ? number.Select(x => x * 2).ToArray()
                    : number.Select(x => x - 1).ToArray();
        };

        string command = Console.ReadLine();
        while(command != "end")
        {
            if(command == "print")
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                numbers = appliedArithmetics(numbers, command);
            }

            command = Console.ReadLine();
        }
    }
}

