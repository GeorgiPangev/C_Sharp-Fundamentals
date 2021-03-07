using System;

namespace _1.Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            double cost = int.Parse(Console.ReadLine());
            int monts = int.Parse(Console.ReadLine());

            double montliSave = cost * 0.25;
            double colectedMony = 0.0;
            for (int i = 1; i <= monts; i++)
            {
                if (i%2==1&&i>1)
                {
                    colectedMony-= colectedMony*0.16;

                }
                if (i%4==0)
                {
                    colectedMony += colectedMony * 0.25;
                }
                colectedMony += montliSave;
            }
            if (colectedMony>=cost)
            {
                Console.WriteLine($"Bravo! You can go to Disneyland and you will " +
                    $"have {(colectedMony-cost):F2}lv. for souvenirs.");
            }
            else
            {
                Console.WriteLine($"Sorry. You need {(cost-colectedMony):F2}lv. more.");
            }

        }
    }
}
