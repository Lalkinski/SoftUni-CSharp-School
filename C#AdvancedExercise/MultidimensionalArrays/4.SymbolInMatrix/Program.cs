/*
3
ABC
DEF
X!@
!

 */
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char[,] matrix = new char[n, n];

        for (int i = 0; i < n; i++)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string line = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            var symbol = char.Parse(Console.ReadLine());

            for (int row = 0;row < n; row++)
            {
                for(int col = 0;col < n; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
            return;
        }

    }
}

