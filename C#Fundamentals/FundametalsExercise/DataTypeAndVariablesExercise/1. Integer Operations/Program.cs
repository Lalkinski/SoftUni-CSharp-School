namespace _1._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firtstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int ThirdNumber = int.Parse(Console.ReadLine());
            int FourtdNumber = int.Parse(Console.ReadLine());

            int firstSum = firtstNumber + SecondNumber;
            int secondSum = firstSum / ThirdNumber;

            int finalSum = FourtdNumber * secondSum;

            Console.WriteLine(finalSum);

        }
    }
}
