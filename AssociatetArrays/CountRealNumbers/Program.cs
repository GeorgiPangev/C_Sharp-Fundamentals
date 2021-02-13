using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, int> dict = new SortedDictionary<int, int>();
            int[] input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            foreach (var num in input)
            {
                if (dict.ContainsKey(num) == false)
                {
                    dict.Add(num, 0);
                    
                }
                dict[num]++;
            }

            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
