using System;

namespace _02.HalfSum_lement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum = 0;
            int max = int.MinValue;

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                sum += num;
                if (num > max)
                {
                    max = num;
                }

            }
            int sumWitoutMax = sum - max;
            if (sumWitoutMax == max)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {max}");
            }
            else/* if (sumWitoutMax != max)*/
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sumWitoutMax - max)}");
            }
        }
    }
}
