﻿using System;

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

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
    }
    static void Main(string[] args)
    {
        string[] articleInfo = Console.ReadLine().Split(", ");
        string title = articleInfo[0];
        string content = articleInfo[1];
        string author = articleInfo[2];

        Article article = new Article(title, content, author);

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split(": ");
            string action = command[0];
            string parameter = command[1];

            switch (command[0])
            {
                case "Edit":
                    article.Edit(parameter);
                    break;
                case "ChangeAuthor":
                    article.ChangeAuthor(parameter);
                    break;
                case "Rename":
                    article.Rename(parameter);
                    break;
            }
        }

        Console.WriteLine(article);
    }
}
