namespace DateModifier
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstDateAsString = Console.ReadLine();
            string secondDateAsString = Console.ReadLine();

            DateTime firstDate = DateTime.Parse(firstDateAsString);
            DateTime secondDate = DateTime.Parse(secondDateAsString);

            int daysDiff = DateModifier.CalculateDateDiffDays(firstDate, secondDate);

            Console.WriteLine(daysDiff);
        }
    }
}
