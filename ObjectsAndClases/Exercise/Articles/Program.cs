using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split(", ")
                 .ToArray();

            Articles art = new Articles(input[0], input[1], input[2]);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine()
                    .Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                switch (comand[0])
                {
                    case "Edit":
                        art.ChangeContent(comand[1]);
                        break;
                    case "ChangeAuthor":
                        art.ChangeAutor(comand[1]);
                        break;
                    case "Rename":
                        art.ChangeTitle(comand[1]);
                        break;
                }

            }
            Console.WriteLine(art.ToString());
        }

      
    }
    class Articles
    {

        public Articles(string title, string content, string author)
        {
            Title = title;
            Content = content;

            Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public  void ChangeContent(string v)
        {
            Content = v;
        }
        public void ChangeAutor(string or)
        {
            Author = or;
        }
        public void ChangeTitle(string title)
        {
            Title = title;
        }
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
