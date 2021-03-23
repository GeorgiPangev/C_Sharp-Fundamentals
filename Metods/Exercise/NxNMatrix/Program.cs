using System;

namespace NxNMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintMatrix(n);
        }
        private static void PrintMatrix(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
