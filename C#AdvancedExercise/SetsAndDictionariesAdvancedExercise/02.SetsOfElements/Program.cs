/*
4 3
1
3
5
7
3
4
5
 */
class Program
{
    static void Main()
    {
        int[] board = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int n = board[0];
        int m = board[1];

        HashSet<int> nSet = new HashSet<int>();
        HashSet<int> mSet = new HashSet<int>();

        HashSet<int> bothSet = new HashSet<int>();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            nSet.Add(number);   
        }
        for (int i = 0;i < m; i++)
        {
            int number = int.Parse(Console.ReadLine());
            mSet.Add(number);
        }

        foreach (int i in nSet)
        {
            if (mSet.Contains(i))
            {
                bothSet.Add(i);
            }
        }

        Console.WriteLine(string.Join(" ", bothSet));
    }
}

