/*
5
10 20 30
1 2 3
2
2
10 10
End

5
10 20 30
1 2 3
2
2
10 10
Add 0 10 10
Add 0 0 10
Subtract -3 0 10
Subtract 3 0 10
End
 */

class Program
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[rows][];

        for (int row = 0; row < jaggedArray.Length; row++)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            jaggedArray[row] = input;
        }

        for (int row = 0; row < jaggedArray.Length - 1; row++)
        {
            if (jaggedArray[row].Length == jaggedArray[row + 1].Length)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] *= 2;
                    jaggedArray[row + 1][col] *= 2;
                }
            }
            else
            {
                for(int col = 0; col < jaggedArray[row].Length; col++)
                {
                    jaggedArray[row][col] /= 2;
                }

                for (int col = 0; col < jaggedArray[row + 1].Length; col++)
                {
                    jaggedArray[row + 1][col] /= 2;
                }
            }
        }

        string command;
        while ((command = Console.ReadLine()) != "End")
        {
            string[] token = command.Split();
            string action = token[0];

            int row = int.Parse(token[1]);
            int col = int.Parse(token[2]);
            int value = int.Parse(token[3]);

            if(action == "Add" && IsInside(jaggedArray, row, col))
            {
                jaggedArray[row][col] += value;
            }
            else if(action == "Subtract" && IsInside(jaggedArray, row, col))
            {
                jaggedArray[row][col] -= value;
            }
        }

        for (int row = 0; row < jaggedArray.Length; row++)
        {
            Console.WriteLine(string.Join(" ", jaggedArray[row]));
        }
    }

    public static bool IsInside(int[][] array, int row,int col)
    {
        return row >= 0 && row < array.Length
        && col >= 0 && col < array[row].Length;
    }
}

