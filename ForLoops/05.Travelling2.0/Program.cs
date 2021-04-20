using System;

namespace _05.Travelling2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            String dest = Console.ReadLine();
            double cost = double.Parse(Console.ReadLine());

            double sum = 0;

            while (dest != "End")
            {
                
                while (cost>= sum)
                {
                    double incom = double.Parse(Console.ReadLine());

                    sum += incom;
                }
                sum = 0;
                Console.WriteLine($"Going to {dest}!");

                dest = Console.ReadLine();
                if (dest == "End")
                { break; }
                cost = double.Parse(Console.ReadLine());

            }
        }
    }
}
