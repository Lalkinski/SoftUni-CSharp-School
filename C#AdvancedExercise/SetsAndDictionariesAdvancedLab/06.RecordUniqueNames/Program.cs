/*
8
John
Alex
John
Sam
Alex
Alice
Peter 
Alex
 */
class Program
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            set.Add(Console.ReadLine());
        }

        Console.WriteLine(string.Join("\n", set));
    }
}

