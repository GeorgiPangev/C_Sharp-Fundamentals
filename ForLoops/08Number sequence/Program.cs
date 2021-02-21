using System;

namespace _08Number_sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int repeets = int.Parse(Console.ReadLine());
          

            int maxNum = int.MinValue;
                int minNum = int.MaxValue;

            for (int i = 1; i <= repeets; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number > maxNum)
                {
                    maxNum = number;
                }
                if (number < minNum)
                {
                    minNum = number;
                }
            }
            Console.WriteLine($"Max number: {maxNum}");
            Console.WriteLine($"Min number: {minNum}");   
        }
    }
}
