using System;

namespace FactorialDivison
{
    class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            Console.WriteLine($"{FactorelCount(first)/FactorelCount(second):F2} ");

        }
        private static double FactorelCount(double x)
        {
            double calculecion = x;

            for (double i = x-1; i >= 1; i--)
            {
                calculecion *= i;
            }
            return calculecion;
        

        }
    }
}
