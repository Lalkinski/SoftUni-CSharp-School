namespace _06._List_Manipulation_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string line;
            while((line = Console.ReadLine()) != "end")
            {
                string[] token = line.Split();

                string command = token[0];
                

                if(command == "Add")
                {
                    list.Add(int.Parse(token[1]));
                }
                else if(command == "Remove")
                {
                    list.Remove(int.Parse(token[1]));
                }
                else if(command == "Insert")
                {
                    int index = int.Parse(token[2]);
                    int number = int.Parse(token[1]);
                    list.Insert(index, number);
                }
                else
                {
                    int index = int.Parse(token[1]);
                    list.RemoveAt(index);
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
