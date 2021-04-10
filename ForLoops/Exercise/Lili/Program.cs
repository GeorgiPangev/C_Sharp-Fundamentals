using System;

namespace Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            Double ages = double.Parse(Console.ReadLine());
            double washingMashinPrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());

            double evenBurthdays = 0;
            double evenmonicont = 0;
            double oddBurthdays = 0;

            for (int i = 1; i <= ages; i++)
            {
                if (i %2==0)
                {
                    evenBurthdays += 1;
                    evenmonicont = evenmonicont + (evenBurthdays * 10); 

                }
                else if (i %2 != 0)
                {
                    oddBurthdays += 1;
                }
            }
            double evenSum = evenmonicont - evenBurthdays;
            double oddsum = oddBurthdays * toyPrice;
            double finSum = evenSum + oddsum;
            if (washingMashinPrice <= finSum)
            {
                Console.WriteLine($"Yes! {finSum - washingMashinPrice :F2}");
            }
            else if (washingMashinPrice > finSum)
            {
                Console.WriteLine($"No! {Math.Abs(washingMashinPrice - finSum):F2}");
            }
          


        }
    }
}
