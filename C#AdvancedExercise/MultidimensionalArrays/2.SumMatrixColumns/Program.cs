/*
3, 6
7 1 3 3 2 1
1 3 9 8 5 6
4 6 7 9 1 0

3, 3
1 2 3
4 5 6
7 8 9
 */
class Program
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = sizes[0];
        int cols = sizes[1];

        int[,] matrix = new int[rows, cols];
        int sumCols = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();  
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colElements[col];
            }
        }

        for (int col = 0; col < matrix.GetLength(1); col++)
        {
            int sum = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                sum += matrix[row, col];
            }
            Console.WriteLine(sum);
        }
    }
}

