/*
1 2 3 4 5 6
2

 */
class Program
{
    static void Main()
    {
        List<int> numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int n = int.Parse(Console.ReadLine());

        numbers.Reverse();

        Func<int, int, bool> divisedNumber = (number, num) 
            => number % num == 0;

        List<int> result = numbers.Where(x => !divisedNumber(x, n)).ToList();
        Console.WriteLine(string.Join(" ", result));




        //List<int> divisedNumber = new List<int>();
        //foreach (int i in numbers)
        //{
        //    if(i % n == 0)
        //    {
        //        continue;
        //    }
        //    else
        //    {
        //        divisedNumber.Add(i);
        //    }
        //}

        //Console.WriteLine(string.Join(" ", divisedNumber));
    }
}

