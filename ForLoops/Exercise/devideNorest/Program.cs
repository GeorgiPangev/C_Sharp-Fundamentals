using System;

namespace _6devideNorest
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Double two = 0;
            Double tree = 0;
            Double fore = 0;
            

            for (int i = 1; i <= n; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num% 2 == 0)
                {
                    two += 1;
                }
                if (num % 3 == 0)
                {
                    tree += 1;
                }
                if (num % 4 == 0)
                {
                    fore += 1;
                }
                
            }
            double NumSum = two + tree + fore;
            Console.WriteLine($"{((two / n) * 100):F2}%");
            Console.WriteLine($"{((tree / n) * 100):F2}%");
            Console.WriteLine($"{((fore / n) * 100):F2}%");
        }
    }
}
