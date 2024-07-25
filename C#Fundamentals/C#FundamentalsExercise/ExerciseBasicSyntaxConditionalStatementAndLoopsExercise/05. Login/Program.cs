/*
Acer
login
go
let me in
recA

momo
omom

sunny
rainy
cloudy
sunny
not sunny

 */

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();

            char[] stringArray = username.ToCharArray();
            Array.Reverse(stringArray);
            string reversedStr = new string(stringArray);

            int tries = 4;

            while (true)
            {
                for (int i = tries - 1; i >= 0; i--)
                {
                    string password = Console.ReadLine();

                    if (password == reversedStr)
                    {
                        Console.WriteLine($"User {username} logged in.");
                        return;
                    }
                    if(i == 0)
                    {
                        Console.WriteLine($"User {username} blocked!");
                        return;
                    }
                    else if(password != reversedStr)
                    {
                        Console.WriteLine("Incorrect password. Try again.");
                    }
                }
            }
        }

    }
}