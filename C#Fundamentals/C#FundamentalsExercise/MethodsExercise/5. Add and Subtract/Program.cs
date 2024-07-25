namespace _5._Add_and_Subtract
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int result = sum(firstNumber, secondNumber);
            result = Substract(result, thirdNumber);

            Console.WriteLine(result);
        }

        private static int Substract(int result, int thirdNumber)
        {
            return result - thirdNumber;
        }

        private static int sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
