using System;

namespace oddSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            int oddSum = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("(i)");
                oddSum += 2*i-1;
            }
            Console.WriteLine($"Sum: {oddSum}");
        }
    }
}
