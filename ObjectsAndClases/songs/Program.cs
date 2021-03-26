using System;
using System.Collections.Generic;
using System.Linq;

namespace songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Songs> pesni = new List<Songs>();

            for (int i = 0; i < n; i++)

            {
                string[] input = Console.ReadLine()
               .Split("_")
               .ToArray();

                Songs song = new Songs();

                song.Type = input[0];
                song.Name = input[1];
                song.Time = input[2];

                pesni.Add(song);
            }
            string select = Console.ReadLine();

            if (select == "all")
            {
                for (int i = 0; i < pesni.Count; i++)
                {
                    Console.WriteLine(pesni[i].Name);
                }
            }
            else 
            {
                List<Songs> filter = pesni
                    .Where(s => s.Type == select)
                    .ToList();
                foreach (Songs item in filter)
                {
                    Console.WriteLine(item.Name);
                }
                //for (int i = 0; i < pesni.Count; i++)
                //{
                //    if (select == pesni[i].Type)
                //    {
                //        Console.WriteLine(pesni[i].Name);
                //    }
                //}
            }

        }
    }
}
