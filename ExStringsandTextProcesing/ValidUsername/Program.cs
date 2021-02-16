using System;
using System.Linq;
//using System.Text;

namespace _1.ValidUsername
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            foreach (var item in input)
            {
                if (IsValid(item))
                {
                    Console.WriteLine(item);
                }
            }
        }
        static bool IsValid(string curent)
        {
            return curent.Length >= 3 && curent.Length <= 16
                && (curent.All(c => char.IsLetterOrDigit(c))
                || curent.Contains("-") || curent.Contains("_"));
        }
    }
}
