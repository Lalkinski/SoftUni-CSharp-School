/*
4
Blue -> dress,jeans,hat
Gold -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
Blue dress

4
Red -> hat
Red -> dress,t-shirt,boxers
White -> briefs,tanktop
Blue -> gloves
White tanktop

5
Blue -> shoes
Blue -> shoes,shoes,shoes
Blue -> shoes,shoes
Blue -> shoes
Blue -> shoes,shoes
Red tanktop
 */
class Program
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split(" -> ");
            string color = input[0];
            string[] items = input[1].Split(",");

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe[color] = new Dictionary<string, int>();
            }

            foreach(string item in items)
            {
                if (!wardrobe[color].ContainsKey(item))
                {
                    wardrobe[color][item] = 0;
                }

                wardrobe[color][item]++;
            }
        }

        string[] search = Console.ReadLine().Split(' ');
        string searchColor = search[0];
        string searchItem = search[1];

        foreach(var color in wardrobe)
        {
            Console.WriteLine($"{color.Key} clothes:");

            foreach(var item in color.Value)
            {
                if(color.Key == searchColor && item.Key == searchItem)
                {
                    Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {item.Key} - {item.Value}");
                }
            }
        }
    }
}

