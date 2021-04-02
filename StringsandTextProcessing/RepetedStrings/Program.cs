using System;
using System.Linq;
using System.Text;

namespace RepetedStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            StringBuilder repeate = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {



                for (int j = 0; j < input[i].Length; j++)
                {

                    repeate.Append(input[i]);
                }
           }
            Console.WriteLine(repeate.ToString());
        }
    }
}
