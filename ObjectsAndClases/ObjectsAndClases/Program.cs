using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsAndClases
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                .Split()
                .ToList();

            Random rnd = new Random();
            for (int i = 0; i < input.Count; i++)
            {
                int posr = rnd.Next(i, input.Count - 1);
                string ii = input[i];
                string ri = input[posr];
                input.RemoveAt(i);
                input.Insert(i, ri);
                input.RemoveAt(i);
                input.Insert(posr, ii);

            }
            Console.WriteLine(string.Join(Environment.NewLine, input));

        }
    }
}
