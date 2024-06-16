/*
4
Hummer H2
Audi
Lada
Tesla
Renault
Trabant
Mercedes
MAN Truck
green
green
Tesla
Renault
Trabant
end

3
Enzo's car
Jade's car
Mercedes CLS
Audi
green
BMW X5
green
end
 */
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Queue<string> queue = new Queue<string>();
        Queue<string> carsToGo = new Queue<string>();
        string input;
        while((input = Console.ReadLine()) != "end")
        {
            
            if(input == "green")
            {
                for(int i = 0; i < n; i++)
                {
                    if(queue.Count == 0)
                    {
                        break;
                    }
                    string carToGo = queue.Dequeue();
                    carsToGo.Enqueue(carToGo);
                    Console.WriteLine($"{carToGo} passed!");
                }
                continue;
            }
            else
            {
                queue.Enqueue(input);
            }
        }

        Console.WriteLine($"{carsToGo.Count} cars passed the crossroads. ");
    }
}
