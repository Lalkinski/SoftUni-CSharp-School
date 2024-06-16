/*
IN, CA2844AA
IN, CA1234TA
OUT, CA2844AA
IN, CA9999TT
IN, CA2866HI
OUT, CA1234TA
IN, CA2844AA
OUT, CA2866HI
IN, CA9876HH
IN, CA2822UU
END
 */
class Program
{
    static void Main()
    {
        HashSet<string> set = new HashSet<string>();
        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] token = command.Split(", ");
            string action = token[0];

            if (action == "IN")
            {
                set.Add(token[1]);
            }
            else if (action == "OUT")
            {
                set.Remove(token[1]);
            }
        }
        if (set.Count <= 0)
        {
            Console.WriteLine($"Parking Lot is Empty");
        }
        else
        {

            Console.WriteLine(string.Join("\n", set));
        }
    }
}

