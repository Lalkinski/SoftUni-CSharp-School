/*
5
register John CS1234JS
register George JAVA123S
register Andy AB4142CD
register Jesica VR1223EE
unregister Andy
 */
namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> parking = new Dictionary<string, string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                


                if (input[0] == "register")
                {
                    string name = input[1];
                    string licensePlateNumber = input[2];
                    if (!parking.ContainsKey(name))
                    {
                        parking.Add(name, licensePlateNumber);
                        Console.WriteLine($"{name} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (input[0] == "unregister")
                {
                    string name = input[1];
                    if (!parking.ContainsKey(name))
                    {
                        Console.WriteLine($"ERROR: user {name} not found");
                    }
                    else
                    {
                        parking.Remove(name);
                        Console.WriteLine($"{name} unregistered successfully");
                    }

                }

            }
                foreach (var kvp in parking)
                {
                    Console.WriteLine($"{kvp.Key} => {kvp.Value}");
                }
        }
    }
}
