using System;

namespace addAsubstract
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            int sum = Sum(a, b);
            Console.WriteLine(MinusSum(sum, c));


        }
        private static int Sum(int x, int y)
        {
            return x + y;
        }
        private static int MinusSum(int x, int c)
        {
            return x - c;
        }
    }
}
