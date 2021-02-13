using System;
using System.Collections.Generic;

namespace Sinonims
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string word = Console.ReadLine();
                string sinonim = Console.ReadLine();

                if (dict.ContainsKey(word))
                {
                    dict[word].Add(sinonim);
                }
                else
                {
                    dict.Add(word, new List<string> {sinonim});
                    //dict[word].Add(sinonim);
                }

            }
            foreach (var word in dict)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
