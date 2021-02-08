using System;

namespace _1.StudInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = Double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:F2}");
        }
    }
}
