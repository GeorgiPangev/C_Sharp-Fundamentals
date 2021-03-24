using System;
using System.Linq;

namespace VowelCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string instr = Console.ReadLine()
                .ToLower();
               
           
            Console.WriteLine(VovelCounter(instr));


        }

        private static int VovelCounter(string input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                
                if ("aeiou".Contains(input[i].ToString()))
                {
                    count++;
                }
            }
            return count;
        }
    }
}
