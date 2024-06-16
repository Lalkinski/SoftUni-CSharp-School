/*
3
11 2 4
4 5 6
10 8 -12

3
4 2 11
6 5 4
-12 8 12
 */
class Program
{
    static void Main()
    {
        int boards = int.Parse(Console.ReadLine());
        int rows = boards;
        int cols = boards;

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colElement = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colElement[col];
            }
        }
        int primaryDiagonal = 0;
        int secondaryDiagonal = 0;

        for (int i = 0; i < boards; i++)
        {
            primaryDiagonal += matrix[i, i];
        }

        for (int i = boards - 1; i >= 0; i--)
        {
            secondaryDiagonal += matrix[i, boards - 1 - i];
        }

        ;

        Console.WriteLine(Math.Abs(primaryDiagonal - secondaryDiagonal));
    }
}
