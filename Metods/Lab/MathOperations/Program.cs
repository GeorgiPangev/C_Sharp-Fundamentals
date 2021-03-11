using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double y = double.Parse(Console.ReadLine());

            double result = Calculated(x, @operator, y);
            Console.WriteLine($"{Math.Round(result,2)}");
        }
        static double Calculated(double x, string did, double y)
        {
            double returned = 0d;
            switch (did)
            {
                case "/":
                    returned = x / y;
                    break;
                case "*":
                    returned = x * y;
                    break;
                case "+":
                    returned = x + y;
                    break;
                case "-":
                    returned = x - y;
                    break;
            }
            return returned;
        }
    }
}
