/*
5 4 8 6 3 8 7 7 9
16

1 7 8 2 5 4 7 8 9 6 3 2 5 4 6
20
 */
class Program
{
    static void Main()
    {
        Stack<int> clothes = new Stack<int>(Console.ReadLine().Split(' ').Select(int.Parse));
        int piece = int.Parse(Console.ReadLine());

        int rack = 1;
        int capacityOfRack = piece;

        while(clothes.Count > 0)
        {
            int clotheToMove = clothes.Pop();
             
            if(clotheToMove <= capacityOfRack)
            {
                capacityOfRack -= clotheToMove;
            }
            else
            {
                rack++;
                capacityOfRack = piece - clotheToMove;
            }
        }

        Console.WriteLine(rack);
    }
}

