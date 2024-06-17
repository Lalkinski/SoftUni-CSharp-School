namespace _06._Calculate_Rectangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideA = int.Parse(Console.ReadLine());
            int sideB = int.Parse(Console.ReadLine());

            int area = 0;

            area = (sideA * sideB);

            Console.WriteLine(area);
        }
    }
}
