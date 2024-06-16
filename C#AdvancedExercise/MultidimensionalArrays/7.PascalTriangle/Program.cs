class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        long[][] jaggedArray = new long[n][];

        jaggedArray[0] = new long [1] { 1 };

        for (int row = 1; row < n; row++)
        {
            jaggedArray[row] = new long[row + 1];

            for (int col = 0; col < jaggedArray[row].Length; col++)
            {
                if (col < jaggedArray[row - 1].Length)
                {
                    jaggedArray[row][col] += jaggedArray[row - 1][col];
                }
                if (col > 0)
                {
                    jaggedArray[row][col] += jaggedArray[row - 1][col - 1];
                }
            } 
        }

        for(int row = 0; row < jaggedArray.Length; row++)
        {
            for(int col = 0; col < jaggedArray[row].Length; col++)
            {
                Console.Write(jaggedArray[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}

