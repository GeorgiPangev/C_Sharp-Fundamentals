using System;

namespace Even_or_Odd
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            int b = a % 2;

                if (b == 0)
            { Console.WriteLine("even"); }
             else 
            { Console.WriteLine("odd"); }
        }
    }
}
