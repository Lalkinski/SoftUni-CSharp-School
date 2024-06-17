internal class Program
{
    static void Main(string[] args)
    {
        string type = Console.ReadLine();

        string firstValue = Console.ReadLine();
        string secondValue = Console.ReadLine();

        if(type == "string")
        {
            GetMax(firstValue, secondValue);
        }
        else if(type == "int")
        {
            GetMax(int.Parse(firstValue), int.Parse(secondValue));
        }
        else if(type == "char")
        {
            GetMax(char.Parse(firstValue), char.Parse(secondValue));
        }
    }


    static void GetMax(int a, int b)
    {
        Console.WriteLine(a < b ? b : a);
    }
    static void GetMax(string a, string b)
    {
        int result = a.CompareTo(b);
        if (result > 0)
        {
            Console.WriteLine(a);
        }
        else
        {
            Console.WriteLine(b);
        }
    }
    static void GetMax(char a, char b)
    {
        Console.WriteLine(a < b ? b : a);
    }
}