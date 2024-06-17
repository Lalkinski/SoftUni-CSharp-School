namespace _11._Multiplication_Table_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            if(sum <= 10)
            {
                for (int i = sum; i <= 10; i++)
                {
                    sum = number * i;
                    Console.WriteLine($"{number} X {i} = {sum}");
                }
            }
            else
            {
                int result = sum * number;
                Console.WriteLine($"{number} X {sum} = {result}");
            }
        }
    }
}