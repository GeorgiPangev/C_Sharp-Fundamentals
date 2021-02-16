using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            StringBuilder encripted = new StringBuilder(input.Length);
            for (int i = 0; i < input.Length; i++)
            {
                int n = input[i] + 3;
                encripted.Append((char)n);
            }
            Console.WriteLine(encripted.ToString());

        }
    }
}
