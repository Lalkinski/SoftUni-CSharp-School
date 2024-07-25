/*
32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end
*/

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
           List<int> wagon = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToList();
           int maxCapacity = int.Parse(Console.ReadLine());

           string input;
           while ((input = Console.ReadLine()) != "end")
           {
               string[] commands = input.Split().ToArray();
                string command = commands[0];

                if (command == "Add")
                {
                    int number = int.Parse(commands[1]);
                    wagon.Add(number);
                    continue;
                }

                int sum = 0;

                for (int i = 0; i < wagon.Count; i++)
                {
                    int peopleAdd = int.Parse(commands[0]);
                    if (wagon[i] + peopleAdd <= maxCapacity)
                    {
                        sum = peopleAdd + wagon[i];

                        wagon[i] = sum;
                        break;
                    }
                }
           }

           Console.WriteLine(string.Join(" ", wagon));
        }
    }
}
