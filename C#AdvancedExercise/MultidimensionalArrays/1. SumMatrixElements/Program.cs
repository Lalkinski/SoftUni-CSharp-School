/*
3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0

 */
class Program
{
    static void Main()
    {
        int[] sizes = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = sizes[0];
        int cols = sizes[1];
                              //x, y
        int[,] matrix = new int[rows, cols];

        int sum = 0;

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colsElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                sum += colsElements[col];
                matrix[row, col] = colsElements[col];
            }
        }

        Console.WriteLine(rows);
        Console.WriteLine(cols);
        Console.WriteLine(sum);
    }
}
