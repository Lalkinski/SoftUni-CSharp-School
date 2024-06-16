/*
348
20 54 30 16 7 9

499 
57 45 62 70 33 90 88 76

100
40 50 20 30 40
 */
class Program
{
    static void Main()
    {
        int foodQuantity = int.Parse(Console.ReadLine());

        Queue<int> orders = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

        Console.WriteLine(orders.Max());

        while(orders.Count > 0 && foodQuantity > 0)
        {
            if(foodQuantity - orders.Peek() >= 0)
            {
                int currentOrder = orders.Dequeue();
                foodQuantity -= currentOrder;
            }
            else
            {
                break;
            }
        }

        if(orders.Count == 0)
        {
            Console.WriteLine("Orders complete");
        }
        else
        {
            Console.WriteLine($"Orders left: {string.Join(" ", orders)}");
        }
    }
}

