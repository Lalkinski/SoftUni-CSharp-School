namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int litersWater = 0;

            for (int i = 0; i < n; i++)
            {
                int quantites = int.Parse(Console.ReadLine());

                litersWater += quantites;

                if (litersWater > 255)
                {
                    Console.WriteLine("Insufficient capacity!");
                    litersWater -= quantites;
                }
            }

            Console.WriteLine(litersWater);
        }
    }
}
