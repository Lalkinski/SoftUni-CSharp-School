/*
1 10
odd 

20 30
even
 */
class Program
{
    static void Main()
    {
        int[] board = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int start = board[0];
        int end = board[1];

        string type = Console.ReadLine();

        List<int> numbers = Enumerable.Range(start, end - start + 1).ToList();

        Predicate<int> isEven = x => x % 2 == 0;
        Predicate<int> isOdd = x => x % 2 != 0;

        var filter = numbers.FindAll(type == "even" ? isEven : isOdd);
        var result = string.Join(" ", filter);

        Console.WriteLine(result);
    }
}

