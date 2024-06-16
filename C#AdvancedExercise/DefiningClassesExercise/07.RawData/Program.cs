namespace _07.RawData
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);
                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoType, cargoWeight);

                Tire[] tires = new Tire[4];
                int counter = 0;
                for (int j = 5; j <= 12; j += 2)
                {
                    double tirePreassure = double.Parse(input[j]);
                    int tireAge = int.Parse(input[j + 1]);
                    tires[counter++] = new Tire(tireAge, tirePreassure);
                }

                Car car = new Car(model, engine, cargo, tires);
                cars.Add(car);
            }

            string typeOfCargo = Console.ReadLine();

            cars.Where(car => car.Cargo.Type == typeOfCargo
                   && (typeOfCargo == "fragile"
                       ? car.Tire.Any(x => x.Preassure < 1)
                       : car.Engine.Power > 250))
               .ToList()
               .ForEach(x => Console.WriteLine(x.Model));

        }
    }
}