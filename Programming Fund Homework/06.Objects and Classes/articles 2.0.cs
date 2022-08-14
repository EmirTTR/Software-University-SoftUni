using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Articles_2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            string[] input;
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(", ");
                Article article = new Article (input[0], input[1], input[2]);
              
                articles.Add(article);
            }
            string[] command = Console.ReadLine().Split();

           if (command[0] == "title")
            {
                foreach (var item in articles.OrderBy(x => x.Title))
                {
                }
                    Console.WriteLine(string.Join(Environment.NewLine, articles));
            }
            else if (command[0] == "content")
            {
                foreach (var item in articles.OrderBy(x=>x.Content))
                {
                }
                    Console.WriteLine(string.Join(Environment.NewLine, articles));
            }
            else if (command[0] == "author")
            {
                foreach (var item in articles.OrderBy(x => x.Author))
                {
                }
                    Console.WriteLine(string.Join(Environment.NewLine, articles));
            }

        }
    }
    class Article
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
}
