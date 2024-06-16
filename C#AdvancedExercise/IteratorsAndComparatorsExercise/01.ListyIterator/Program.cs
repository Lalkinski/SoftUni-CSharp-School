namespace _01.ListyIterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            ListyIterator library = new ListyIterator(names);


            string[] createCommand = Console.ReadLine().Split();

            library.Create(createCommand.Skip(1).ToList());

            string command = Console.ReadLine();
            while (command != "END")
            {
                string[] token = command.Split();

                if (token[0] == "Move")
                {
                    Console.WriteLine(library.Move());
                }
                else if (token[0] == "Print")
                {
                    try
                    {
                        library.Print();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                else if (token[0] == "HasNext")
                {
                    Console.WriteLine(library.HasNext());
                }

                command = Console.ReadLine();
            }
        }
    }
}
