using System;

namespace T02._Articles.ex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currArticle = Console.ReadLine().Split(", ");
            Article article = new Article(currArticle[0], currArticle[1], currArticle[2]);
            int NumOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumOfCommands; i++)
            {
                string[] cmd = Console.ReadLine().Split(": ");
                string mainCmd = cmd[0];
                string argument = cmd[1];

                switch (mainCmd)
                {
                    case "Edit":
                        article.Edit(argument);
                        break;

                    case "ChangeAuthor":
                        article.ChangeAuthor(argument);
                        break;

                    case "Rename":
                        article.Rename(argument);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
    class Article
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

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }

        public void Edit(string content) => Content = content;
        public void ChangeAuthor(string author) => Author = author;
        public void Rename(string title) => Title = title;
    }
}