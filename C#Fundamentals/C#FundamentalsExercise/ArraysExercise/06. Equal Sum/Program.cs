namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int index = -1;
            for (int i = 0; i < array.Length; i++)
            {

                index = -1;
                int rightSum = 0;
                int leftSum = 0;

                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += array[j];
                }

                for(int j = i + 1; j < array.Length; j++)
                {
                    rightSum += array[j];
                }

                if(rightSum == leftSum)
                {
                    index = i;
                    break;
                }
            }

                if(index != -1)
                {
                    Console.WriteLine(index);
                }
                else
                {
                    Console.WriteLine("no");
                }
        }
    }
}
