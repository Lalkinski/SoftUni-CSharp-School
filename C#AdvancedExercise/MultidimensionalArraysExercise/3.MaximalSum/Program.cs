/*
4 5
1 5 5 2 4
2 1 4 14 3
3 7 11 2 8
4 8 12 16 4

 */
class Program
{
    static void Main()
    {
        int[] boards = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
        int rows = boards[0];
        int cols = boards[1];  
        
        int[,] matrix = new int[rows, cols];

        for(int row = 0; row < matrix.GetLength(0); row++)
        {
            int[] colElements = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            for(int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row,col] = colElements[col];
            }
        }
        
        ;
        int sum = int.MinValue;
        int startIndex = 0;
        int endIndex = 0;
        for(int row = 0;row < matrix.GetLength(0) - 2; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if(currentSum > sum)
                {
                    sum = currentSum;
                    startIndex = row; ;
                    endIndex = col;
                }
            }
        }

        Console.WriteLine($"Sum = {sum}");

        for (int row = startIndex; row < startIndex + 3; row++)
        {
            for (int col = endIndex; col < endIndex + 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}

