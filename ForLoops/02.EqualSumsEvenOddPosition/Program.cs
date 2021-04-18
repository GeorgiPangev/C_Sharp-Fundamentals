using System;

namespace _02.EqualSumsEvenOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumb = int.Parse(Console.ReadLine());
            int secNumb = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;

            for (int i = firstNumb; i <= secNumb; i++)
            {
               
                string courent = i.ToString();
                for (int j = 0; j < courent.Length; j++)
                {
                    int digit = int.Parse(courent[j].ToString());

                    if (j %2 == 0)
                    {
                        evenSum += digit;
                    }
                    else
                    {
                        oddSum += digit;
                    }
                }
                if (evenSum == oddSum)
                {
                    Console.Write(i + " ");
                }
                evenSum = 0;
                oddSum = 0;

            }

        }
    }
}
