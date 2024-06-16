/*
6
John
John
John
Peter
John
Boy1234
 */
class Program
{
    static void Main()
    {
        HashSet<string> usernames = new HashSet<string>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string input = Console.ReadLine();

            usernames.Add(input);
        }

        foreach(var item in  usernames)
        {
            Console.WriteLine(item);
        }
    }
}

