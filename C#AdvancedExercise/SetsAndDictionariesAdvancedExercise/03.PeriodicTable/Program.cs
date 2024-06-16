/*
4
Ce O
Mo O Ce
Ee
Mo

3
Ge Ch O Ne
Nb Mo Tc
O Ne
 */
class Program
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();

            for (int j = 0; j < input.Length; j++)
            {
                set.Add(input[j]);
            }
        }

        var sortedSet = set.OrderBy(s => s);

        Console.WriteLine(string.Join(" ", sortedSet));
    }
}

