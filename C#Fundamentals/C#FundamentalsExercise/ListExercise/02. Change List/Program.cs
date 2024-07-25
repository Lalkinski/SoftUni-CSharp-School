/*
1 2 3 4 5 5 5 6
Delete 5
Insert 10 1
Delete 5
end
 
 */

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            string input;
            while((input = Console.ReadLine()) != "end")
            {
                string[] command = input.Split().ToArray();
                string speed = command[0];

                if (command[0] == "Delete")
                {
                    int number = int.Parse(command[1]);

                    numbers.RemoveAll(x => x == number);

                }
                else if (command[0] == "Insert")
                {
                    int element = int.Parse(command[1]);
                    int postition = int.Parse(command[2]);

                    numbers.Insert(postition, element);
                }
            }

            

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
