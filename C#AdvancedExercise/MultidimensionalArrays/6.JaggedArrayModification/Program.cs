/*
3
1 2 3
4 5 6 7
8 9 10
Add 0 0 5
Subtract 1 2 2 
Subtract 1 4 7 
END
 */
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[][] jagedArrays = new int[n][];

        for (int row = 0; row < jagedArrays.GetLength(0); row++)
        {
            jagedArrays[row] = Console.ReadLine().Split().Select(int.Parse).ToArray();
        }

        string command;
        while ((command = Console.ReadLine()) != "END")
        {
            string[] splittedCommand = command.Split(' ').ToArray();

            string action = splittedCommand[0];
            int row = int.Parse(splittedCommand[1]);
            int col = int.Parse(splittedCommand[2]);
            int value = int.Parse(splittedCommand[3]);

            if (row < 0 || row >= jagedArrays.Length || jagedArrays[row].Length <= col || col < 0)
            {
                Console.WriteLine("Invalid coordinates");
                continue;
            }

            if (action == "Add")
            {
                jagedArrays[row][col] += value;
            }
            else if (action == "Subtract")
            {

                jagedArrays[row][col] -= value;
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        for (int row = 0; row < jagedArrays.Length; row++)
        {
            for (int col = 0; col < jagedArrays[row].Length; col++)
            {
                Console.Write(jagedArrays[row][col] + " ");
            }
            Console.WriteLine();
        }
    }
}

