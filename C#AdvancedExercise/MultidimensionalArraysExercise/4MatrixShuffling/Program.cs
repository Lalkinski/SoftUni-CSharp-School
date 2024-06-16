/*
2 3
1 2 3
4 5 6
swap 0 0 1 1
swap 10 9 8 7
swap 0 1 1 0
END

1 2
Hello World
0 0 0 1
swap 0 0 0 1
swap 0 1 0 0
END

 */
class Program
{
    static void Main()
    {
        int[] board = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int rows = board[0];
        int cols = board[1];

        string[,] matrix = new string[rows, cols];

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            string[] input = Console.ReadLine().Split();
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                matrix[row,col] = input[col];
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] tokens = command.Split();
            if(tokens.Length != 5 ||
                tokens[0] != "swap")
            {
                Console.WriteLine("Invalid input!");
                continue;
            }
            
            int firstRow = int.Parse(tokens[1]);
            int firstCol = int.Parse(tokens[2]);

            int secondRow = int.Parse(tokens[3]);
            int secondCol = int.Parse(tokens[4]);

            if (firstRow >= 0 && firstRow < matrix.GetLength(0) &&
                firstCol >= 0 && firstCol < matrix.GetLength(1) &&
                secondRow >= 0 && secondRow < matrix.GetLength(0) &&
                secondCol >= 0 && secondRow < matrix.GetLength(1))
            {
                string value = matrix[firstRow, firstCol];
                matrix[firstRow, firstCol] = matrix[secondRow, secondCol];
                matrix[secondRow, secondCol] = value;

                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        Console.Write(matrix[row, col] + " ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input!");
            }
        }
    }
}

