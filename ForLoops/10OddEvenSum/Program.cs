using System;

namespace _10OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {

            int repeets = int.Parse(Console.ReadLine());

            int evensum = 0;
            int oddsum = 0;



            for (int i = 0; i < repeets; i++)
            {
                int curentNumb = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evensum += curentNumb;
                }
                if (i % 2 != 0)
                {
                    oddsum += curentNumb;
                }
            }
            // lSum += curentNumb;
            //}
            //for (int i = 1; i <= repeets; i++)
            //{
            //    int curentNumb = int.Parse(Console.ReadLine());
            //    rSum += curentNumb;
            //}
            if (evensum == oddsum)
                {
                    Console.WriteLine($"Yes");
                    Console.WriteLine($"Sum = {evensum}");
                }
                if (evensum != oddsum)
                {
                    Console.WriteLine("No");
                    Console.WriteLine($"Diff = {Math.Abs(evensum - oddsum)}");
                }
            
        }
    }
}
