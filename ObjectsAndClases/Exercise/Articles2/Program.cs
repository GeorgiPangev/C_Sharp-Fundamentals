using System;
using System.Collections.Generic;
using System.Linq;

namespace Articles2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Articles> arts = new List<Articles>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine()
                    .Split(", ")
                    .ToArray();
                Articles artNew = new Articles(input[0], input[1], input[2]);
                arts.Add(artNew);
            }
            string comand = Console.ReadLine();

            switch (comand)
            {
                case "title":
                    arts.Sort((t1,t2)=> t1.Title.CompareTo(t2.Title));
   
                    break;

                case "content":
                    arts = arts.OrderBy(c => c.Content).ToList();
                    break;
                case "autor":
                    arts.Sort((a1, a2) => a1.Autor.CompareTo(a2.Autor));
                    break;

            }
            Console.WriteLine(string.Join(Environment.NewLine, arts));
                       
        }
    }
    class Articles
    {
        public Articles(string title, string content, string autor)
        {
            Title = title;
            Content = content;
            Autor = autor;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Autor { get; set; }

        public override string ToString()
        {
            return $"{Title} {Content} {Autor}"; 
        }
    }
}
