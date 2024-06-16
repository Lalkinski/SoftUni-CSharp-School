using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        var engines = new Dictionary<string, Engine>();

        for (int i = 0; i < N; i++)
        {
            var engineData = Console.ReadLine().Split();
            string model = engineData[0];
            int power = int.Parse(engineData[1]);
            int?displacement = engineData.Length > 2
                && int.TryParse(engineData[2], out int disp)
                ? disp
                : null;

            string efficiency = engineData.Length > 3 
                ? engineData[3] 
                : (engineData.Length == 3 
                && !int.TryParse(engineData[2], out _)) 
                ? engineData[2] 
                : null;

            engines[model] = new Engine(model, power, displacement, efficiency);
        }

        int M = int.Parse(Console.ReadLine());
        var cars = new List<Car>();

        for (int i = 0; i < M; i++)
        {
            var carData = Console.ReadLine().Split();
            string model = carData[0];
            Engine engine = engines[carData[1]];
            int? weight = carData.Length > 2 
                && int.TryParse(carData[2], out int w) 
                ? w 
                : null;

            string color = carData.Length > 3 
                ? carData[3] 
                : (carData.Length == 3 
                && !int.TryParse(carData[2], out _)) 
                ? carData[2] 
                : null;

            cars.Add(new Car(model, engine, weight, color));
        }

        foreach (var car in cars)
        {
            Console.WriteLine(car);
        }
    }
}
