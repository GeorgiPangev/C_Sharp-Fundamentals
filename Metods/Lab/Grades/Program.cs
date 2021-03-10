using System;

namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            PrintGrade(grade);
        }
        static void PrintGrade(double gr)
        {
            if (gr>=2.00 && gr<3.00)
            {
                Console.WriteLine("Fail");
            }
            else if (gr >= 3.00 && gr < 3.50)
            {
                Console.WriteLine("Poor");
            }
            else if (gr >= 3.50 && gr < 4.50)
            {
                Console.WriteLine("Good");
            }
            else if (gr >= 4.50 && gr < 5.50)
            {
                Console.WriteLine("Very good");
            } 
            else if (gr >= 5.50 && gr < 6.00)
            {
                Console.WriteLine("Excellent");
            }
        }
    }
}
