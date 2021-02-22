using System;

namespace even2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());


            for (int i = 0; i <= num; i+=2)
            {
                double n = Math.Pow(2, i);
                Console.WriteLine(n);
            }
        }
    }
}
