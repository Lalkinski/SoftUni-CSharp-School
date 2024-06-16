/*
3, 6
7 1 3 3 2 1
1 3 9 8 5 6
4 6 7 9 1 0

3, 6
7, 1, 3, 3, 2, 1
1, 3, 9, 8, 5, 6
4, 6, 7, 9, 1, 0

 */
class Program
{
    static void Main()
    {
        int[] boars = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
        int rows = boars[0];
        int cols = boars[1];

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colElements = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colElements[col];
            }
        }

        int sum = 0;
        int startIndex = 0;
        int nextElement = 0;
        int nextRowFirstElement = 0;
        int newElementInCurrentRow = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];

                if (currentSum > sum)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    startIndex = matrix[row, col];
                    nextElement = matrix[row, col + 1];
                    nextRowFirstElement = matrix[row + 1, col];
                    newElementInCurrentRow = matrix[row + 1, col + 1];
                }
            }

        }
        Console.WriteLine($"{startIndex} {nextElement}");
        Console.WriteLine($"{nextRowFirstElement} {newElementInCurrentRow}");
        Console.WriteLine(sum);
    }
}

