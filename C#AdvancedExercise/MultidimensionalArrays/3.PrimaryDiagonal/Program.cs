/*
3
11 2 4
4 5 6
10 8 -12

3
1 2 3
4 5 6
7 8 9

 */
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colsElement = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colsElement[col];
            }
        }

        int diagonalSum = 0;

        for (int row = 0;row < matrix.GetLength(0); row++)
        {
            for (int col = 0;col < matrix.GetLength(1); col++)
            {
                diagonalSum += matrix[row, col];
                row++;
            }
        }

        Console.WriteLine(diagonalSum);
    }
}

