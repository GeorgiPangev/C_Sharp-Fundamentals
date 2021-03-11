using System;

namespace MathPower
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double pow = double.Parse(Console.ReadLine());

            double powered = DoneMath(n, pow);
            Console.WriteLine(powered);
        }

        private static double DoneMath(double n, double pow)
        {
            double power = Math.Pow(n, pow);
            return power;
        }
    }
}
