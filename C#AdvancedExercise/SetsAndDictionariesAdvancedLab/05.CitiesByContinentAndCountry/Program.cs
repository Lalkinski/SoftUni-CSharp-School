/*
9
Europe Bulgaria Sofia
Asia China Beijing
Asia Japan Tokyo
Europe Poland Warsa
Europe Germany Berlin
Europe Poland Poznan
Europe Bulgaria Plovdiv
Africa Nigeria Abuja
Asia China Shanghai

 */
class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, List<string>>> keyValuePairs = new Dictionary<string, Dictionary<string, List<string>>>();


        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string continent = input[0];
            string country = input[1];
            string cities = input[2];

            if (!keyValuePairs.ContainsKey(continent))
            {
                keyValuePairs[continent] = new Dictionary<string, List<string>>();
            }

            if (!keyValuePairs[continent].ContainsKey(country))
            {
                keyValuePairs[continent][country] = new List<string>();
            }

            keyValuePairs[continent][country].Add(cities);
        }

        foreach (var (continent, country) in keyValuePairs)
        {
            Console.WriteLine($"{continent}:");
            foreach (var (countryName, cities) in country)
            {
                Console.WriteLine($"  {countryName} -> {string.Join(", ", cities)}");

            }
        }

    }
}

