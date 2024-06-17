namespace _05._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string typeOfProduct = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());

            decimal sum = 0;

            switch (typeOfProduct)
            {
                case "coffee":
                    sum = count * 1.50m;
                    break;
                case "water":
                    sum = count * 1.00m;
                    break;
                case "coke":
                    sum = count * 1.40m;
                    break;
                case "snacks":
                    sum = count * 2.00m;
                    break;
            }

            Console.WriteLine(sum);
        }
    }
}
