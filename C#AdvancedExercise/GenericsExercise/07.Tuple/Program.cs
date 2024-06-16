namespace _07.Tuple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personInput = Console.ReadLine().Split();
            string firstName = personInput[0];
            string lastName = personInput[1];
            string addres = personInput[2];

            string[] beerMan = Console.ReadLine().Split();
            string beerManName = beerMan[0];
            int beerManLiters = int.Parse(beerMan[1]);

            string[] value = Console.ReadLine().Split();
            int integerValue = int.Parse(value[0]);
            double doubleValue = double.Parse(value[1]);


            Tuple<string, string, string> personInputTuple = new Tuple<string, string, string>(firstName, lastName, addres);

            Tuple<string, int> beerManeTuple = new Tuple<string, int>(beerManName, beerManLiters);

            Tuple<int, double> valueTuple = new Tuple<int, double>(integerValue, doubleValue);

            Console.WriteLine($"{personInputTuple.Item1} {personInputTuple.Item2} -> {personInputTuple.Item3}");
            Console.WriteLine($"{beerManeTuple.Item1} -> {beerManeTuple.Item2}");
            Console.WriteLine($"{valueTuple.Item1} -> {valueTuple.Item2}");

        }
    }
}
