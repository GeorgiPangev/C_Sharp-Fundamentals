using System;

namespace _09LeftandRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeets = int.Parse(Console.ReadLine());

            int lSum = 0;
            int rSum = 0;

            for (int i = 1; i <= repeets ; i++)
            {
                int curentNumb = int.Parse(Console.ReadLine());
                lSum += curentNumb;
            }
            for (int i = 1; i <=repeets ; i++)
            {
                int curentNumb = int.Parse(Console.ReadLine());
                rSum += curentNumb;
            }
            if (lSum == rSum)
            {
                Console.WriteLine($"Yes, sum = {lSum}");
            }
            if (lSum != rSum)
            {
                Console.WriteLine($"No, diff = {Math.Abs(lSum-rSum)}");
            }
        }
    }
}
