using System;
using System.Linq;

namespace Largest3Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .OrderByDescending(x=>x)
                .ToArray();

            if (input.Length>=3)
            {
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    Console.Write(input[i] + " ");
                }
            }



        }
    }
}
