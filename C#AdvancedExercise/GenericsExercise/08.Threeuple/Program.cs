namespace _07.Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine().Split();
            string firstName = personInput[0];
            string lastName = personInput[1];   
            string address = personInput[2];
            string town = personInput[3];

            string[] beerMan = Console.ReadLine().Split();
            string nameOfBeerMan = beerMan[0];
            int beerManLiters = int.Parse(beerMan[1]);
            string drunkOrNot = beerMan[2];

            string[] value = Console.ReadLine().Split();
            string name = value[0];
            double bankBalance = double.Parse(value[1]);
            string bankName = value[2];

            Tuple<string, string, string, string> personInputTuple = new Tuple<string, string, string, string>(firstName, lastName, address, town);

            Tuple<string, int, string> beerManTuple = new Tuple<string, int, string>(nameOfBeerMan, beerManLiters, drunkOrNot);

            Tuple<string, double, string> valueInput = new Tuple<string, double, string>(name, bankBalance, bankName);

            Console.WriteLine($"{personInputTuple.Item1} {personInputTuple.Item2} -> {personInputTuple.Item3} -> {personInputTuple.Item4}");

            Console.WriteLine($"{beerManTuple.Item1} -> {beerManTuple.Item2} -> " +
                $"{beerManTuple.Item3 == "drunk" : true ? false}");

            Console.WriteLine($"{valueInput.Item1} -> {valueInput.Item2} -> {valueInput.Item3}");
        }
    }
}
