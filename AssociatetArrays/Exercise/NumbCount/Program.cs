using System;
using System.Collections.Generic;
using System.Linq;

namespace NumbCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> chars = new Dictionary<char, int>();

            string[] input = Console.ReadLine()
                .Split()
                .ToArray();

            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < input[i].Length; j++)
                {
                    if (chars.ContainsKey(input[i][j]) == false)
                    {
                        chars.Add(input[i][j], 0);
                    }
                    chars[input[i][j]]++;
                }
            }
            foreach (var c in chars)
            {
                Console.WriteLine($"{c.Key} -> {c.Value}");
            }
        }
    }
}
