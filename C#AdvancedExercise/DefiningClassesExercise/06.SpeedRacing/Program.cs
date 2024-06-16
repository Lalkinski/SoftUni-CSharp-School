namespace SpeedRacing
{
    public class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double fuelConsumptionFor1km = double.Parse(input[2]);
                double travelledDistance = 0;

                cars[model] = new Car(model, fuelAmount, fuelConsumptionFor1km);
            }

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] token = command.Split();
                string carModel = token[1];
                double amountOfKm = double.Parse(token[2]);

                if (cars.ContainsKey(carModel))
                {
                    cars[carModel].Drive(amountOfKm);
                }
            }

            foreach(var car in cars.Values)
            {
                Console.WriteLine(car);
            }
        }
    }
}
