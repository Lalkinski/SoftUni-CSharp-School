namespace _1._Day_of_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 0 length - 1
            string[] nameOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            int number;

            if(int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= 1 && number <= 7)
                {
                    Console.WriteLine(nameOfWeek[number - 1]);
                }
                else
                {
                    Console.WriteLine("Invalid day!");
                }
            }
        }
    }
}
