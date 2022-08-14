using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Article article = new Article(input[0], input[1], input[2]);
           
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i < num; i++)
            {

                string[] inputt = Console.ReadLine().Split(": ");
                string command = inputt[0];
                string word = inputt[1];
                if (command=="Edit")
                {
                    article.Edit(word);
                }
                if (command=="ChangeAuthor")
                {
                    article.ChangeAuthor(word);
                }
                if (command== "Rename")
                {
                    article.Rename(word);
                }
            }
            Console.WriteLine(article);
        }
    }

    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void Edit(string content)
        {
            Content = content;
        }

        public void ChangeAuthor(string author)
        {
            Author = author;
        }

        public void Rename(string title)
        {
            Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
