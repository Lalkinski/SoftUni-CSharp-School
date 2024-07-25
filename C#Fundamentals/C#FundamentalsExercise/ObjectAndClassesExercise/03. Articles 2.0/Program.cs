using System;

class Program
{
    public class Article
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }


    }
    static void Main(string[] args)
    {

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] list = Console.ReadLine().Split(", ");
            string title = list[0];
            string content = list[1];
            string author = list[2];

            Console.WriteLine($"{title} - {content}: {author}");

        }


    }
}
