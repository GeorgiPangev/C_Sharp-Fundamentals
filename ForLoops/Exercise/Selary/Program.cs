using System;

namespace _7Selary
{
    class Program
    {
        static void Main(string[] args)
        {
            Double tabs = Double.Parse(Console.ReadLine());
            Double salary = Double.Parse(Console.ReadLine());

            for (double i = 1; i <= tabs; i++)
            {
                if (salary <= 0)
                {
                    tabs = 0;
                    Console.WriteLine("You have lost your salary.");
                }
                string sites = Console.ReadLine();
                switch (sites)
                    {
                        case "Facebook": salary -= 150; break;
                        case "Instagram": salary -= 100; break;
                        case "Reddit": salary -= 50; break;
                    }    }  
            if (salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            }            
        }
    }
}
