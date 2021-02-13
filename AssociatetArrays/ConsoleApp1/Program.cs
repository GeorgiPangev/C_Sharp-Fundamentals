using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                 .Split()
                 .Where(x => x.Length % 2 == 0)
                 .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
