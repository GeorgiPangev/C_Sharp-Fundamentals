using System;

namespace Multiplicatione1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (y <=10)
            {  
                for (int i = y; i <= 10; i++)
                {
                Console.WriteLine($"{n} X {i} = {n*i}");
                }
            }
            else
            {
                Console.WriteLine($"{n} X {y} = {n * y}");
            }
        }
    }
}
