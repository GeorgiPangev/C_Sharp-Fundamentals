using System;
using System.Linq;


namespace StringMultiplaier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[]  input = Console.ReadLine().Split()
                .ToArray();

            string longWord = input[0];
            string shortWord = input[1];

            if (input[0].Length<input[1].Length)
            {
                longWord = input[1];
                shortWord = input[0];
            }
            int sumOfAll = CharManipolator(longWord, shortWord);
            Console.WriteLine(sumOfAll);


        }
        public static int CharManipolator(string longWord, string shortWord)
        {
            int sum = 0;
            for (int i = 0; i < shortWord.Length; i++)
            {
                sum += shortWord[i] * longWord[i];

            }
            for (int i = shortWord.Length; i < longWord.Length; i++)
            {
                sum += longWord[i];
            }
            return sum;
        }
    }
}
