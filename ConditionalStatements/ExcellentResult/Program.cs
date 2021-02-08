using System;

namespace ExcellentResult
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = Double.Parse(Console.ReadLine());

            if (grade >= 5.50)
                Console.WriteLine("Excellent!");

        }
    }
}
