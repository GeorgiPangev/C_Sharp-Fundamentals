using System;

namespace _03.SumPrimeNonPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            //double n = Double.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            double n = 0;

            double primeSum = 0;
            Double nonPrimeSum = 0;
            bool isStop = false;
            bool nonPrime = false;

            while (input != "stop")
            {
                n = Double.Parse(input);
                if (n==1 || n == 0)
                {
                    nonPrimeSum += n;
                }
                else if (n==2)
                {
                    primeSum += n;
                }
                else if (n>2)
                {
                    for (int i = 2; i < n; i++)
                    {
                        if (n%i == 0)
                        {
                            nonPrime = true; ;
                        }
                    }
                    if (!nonPrime)
                    {
                        primeSum += n;
                    }
                    else if (nonPrime)
                    {
                        nonPrimeSum += n;
                        nonPrime = false;
                    }
                }
                else if (n<0)
                {
                    Console.WriteLine("Number is negative.");
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");


        }
    }
}
