using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._OddOccurrence
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();


            string[] input = Console.ReadLine()
                .ToLower()
                .Split()
                
                .ToArray();

            foreach (var word in input)
            {
                if (dict.ContainsKey(word))
                {
                    dict[word]++;

                }
                else
                {
                    dict.Add(word, 0);
                    dict[word]++;
                }
            }

           

            foreach (var word in dict)
            {
                if (word.Value %2 != 0)
                {
                    Console.Write(word.Key + " ");
                }
            }


                

             
        }
    }
}
