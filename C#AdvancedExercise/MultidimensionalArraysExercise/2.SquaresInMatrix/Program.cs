/*
3 4
A B B D
E B B B
I J B B

4 4
B B D D
B B D D
A A D D
A A D D

2 2
a b
c d

 */
class Program
{
    static void Main()
    {
        int[] boards = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = boards[0];
        int cols = boards[1];

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] colElement = Console.ReadLine().Split();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row, col] = colElement[col][0];
            }
        }
        ;
        int sumOfEqualChars = 0;

        for (int row = 0; row < matrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < matrix.GetLength(1) - 1; col++)
            {
                bool areEqual =
                    (matrix[row, col] == matrix[row + 1, col] &&
                    matrix[row, col + 1] == matrix[row + 1, col + 1] &&
                    matrix[row, col] == matrix[row + 1, col + 1]);

                if (areEqual)
                {
                    sumOfEqualChars++;
                }
            }
        }

        Console.WriteLine(sumOfEqualChars);
    }
}

