using System;

namespace _4.MajicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            double mN = double.Parse(Console.ReadLine());

            bool isFound = false;
            double counter = 0;
            double first = 0;
            double sec = 0;
            for (double x1 = x; x1 <= y; x1++)
            {
                for (double y1 = x; y1 <= y; y1++)
                {
                    counter++;
                    if (x1 + y1 == mN)
                    {
                        first = x1;
                        sec = y1;
                        isFound = true;
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (isFound)
            {
                Console.WriteLine($"Combination N:{counter} ({first} + {sec} = {mN})");
            }
            else if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {mN}");
            }
        }
    }
}
