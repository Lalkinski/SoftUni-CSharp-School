namespace _1._Advertisement_Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> phrases = new List<string> { "Excellent product.", 
                    "Such a great product.", 
                    "I always use that product.", 
                    "Best product of its category.", 
                    "Exceptional product.", 
                    "I can't live without this product."};

            List<string> events = new List<string> { "Now I feel good.", 
                    "I have succeeded with this product.", 
                    "Makes miracles. I am happy of the results!", 
                    "I cannot believe but now I feel awesome.", 
                    "Try it yourself, I am very satisfied.", 
                    "I feel great!"};

            List<string> author = new List<string> { "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie",
                "Eva" };

            List<string> cities = new List<string> { "Burgas", 
                "Sofia",
                "Plovdiv", 
                "Varna", 
                "Ruse" };

             Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                int randomIndex = random.Next(phrases.Count);
                int randomIndex2 = random.Next(events.Count);
                int randomIndex3 = random.Next(author.Count);
                int randomIndex4 = random.Next(cities.Count);

                Console.WriteLine($"{phrases[randomIndex]} {events[randomIndex2]} {author[randomIndex3]} - {cities[randomIndex4]}");
            }
        }
    }
}
