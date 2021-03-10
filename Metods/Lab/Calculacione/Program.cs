using System;

namespace Calculacione
{
    class Program
    {
        static void Main(string[] args)
        {
            string comand = Console.ReadLine();
            int furstI = int.Parse(Console.ReadLine());
            int secondI = int.Parse(Console.ReadLine());
            //add, multiply, subtract, divide

            switch (comand)
            {
                case "add":
                    Add(furstI, secondI);
                    break;
                case "multiply":
                    Multiply(furstI, secondI);
                    break;
                case "subtract":
                    Subtract(furstI, secondI);
                    break;
                case "divide":
                    Divide(furstI, secondI);
                    break;

            }    
            

        }

        private static void Add(int f, int s)
        {
            int result = f + s;
            Console.WriteLine(result);
        }
        private static void Multiply(int f, int s)
        {
            int result = f * s;
            Console.WriteLine(result);
        }
        private static void Subtract(int f,int s)
        {
            int result = f - s;
            Console.WriteLine(result);
        }
        private static void Divide(int f, int s)
        {
            int result = f / s;
            Console.WriteLine(result);
        }

    }
}
