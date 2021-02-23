using System;

namespace NumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeets = int.Parse(Console.ReadLine());
            
            int sum = 0;
            for (int i = 1; i <= repeets ; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;  
            }
            Console.WriteLine(sum);
        }
    }
}
