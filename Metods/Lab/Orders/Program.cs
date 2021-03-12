using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string stock = Console.ReadLine();
            int qualyti = int.Parse(Console.ReadLine());
            switch (stock)
            {
                case "coffee":
                    PricePrint(qualyti, 1.5);
                    break;
                case "water":
                    PricePrint(qualyti, 1.0);
                    break;
                case "coke":
                    PricePrint(qualyti, 1.4);
                    break;
                case "snacks":
                    PricePrint(qualyti, 2);
                    break;
            }


        }
        static void PricePrint(int ps, double priceForOne)
        {
            Console.WriteLine($"{ps*priceForOne:F2}");
        }
    }
}
