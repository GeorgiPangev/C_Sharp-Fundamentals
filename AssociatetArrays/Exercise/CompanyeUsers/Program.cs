using System;
using System.Collections.Generic;
using System.Linq;

namespace CompanyeUsers
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            SortedDictionary<string, List<string>> companis = 
                new SortedDictionary<string, List<string>>();


            while (input[0] != "End")
            {
                
                if (companis.ContainsKey(input[0]) == false)
                {
                    companis.Add(input[0], new List<string> { input[1] });
                }
                else if (companis[input[0]].Contains(input[1]) == false)
                {
                    companis[input[0]].Add(input[1]);
                }

                input = Console.ReadLine()
                .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

               
            }
            foreach (var c in companis)
            {
                Console.WriteLine(c.Key);
                for (int i = 0; i < c.Value.Count; i++)
                {
                    Console.WriteLine($"-- {c.Value[i]}");
                }
            }
        }
    }
}
