using System;

namespace BackInTime
{
    class Program
    {
        static void Main(string[] args)
        {
            double moniinbank = double.Parse(Console.ReadLine());
            double yearsToStay = double.Parse(Console.ReadLine());

            double yearminus18 =  yearsToStay - 1800;

            double moncount = 0;
            double carentYears = 18;

            for (int i = 0; i <= yearminus18; i++)
                //for (int i = 1800; i <= yearminus18; i++)
            {
                carentYears += 1;
                if (i%2 == 0)
                {
                    moncount += 12000;
                }
                else if (i%2 != 0)
                {
                    moncount += (12000 + (50 * (carentYears-1))); 
                }

            }
            if (moncount <= moniinbank)
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {(moniinbank - moncount):f2} dollars left.");
            }
            else if (moncount> moniinbank)
            {
                Console.WriteLine($"He will need {Math.Abs(moniinbank - moncount):F2} dollars to survive.");
            }

            Console.WriteLine($"{moniinbank}/ {moniinbank - moncount} / {moncount}"); 

        }
    }
}
