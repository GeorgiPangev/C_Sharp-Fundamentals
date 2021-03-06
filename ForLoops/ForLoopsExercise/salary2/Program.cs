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
                
                else if (salary > 0)
                {
                    string sites = Console.ReadLine();
                    switch (sites)
                    {
                        case "Facebook": salary -= 150;
                            if (salary <= 0)
                            {
                                tabs = 0;
                                Console.WriteLine("You have lost your salary.");
                            }
                            break;
                        case "Instagram": salary -= 100; 
                            if (salary <= 0)
                            {
                                tabs = 0;
                                Console.WriteLine("You have lost your salary.");
                            }
                            break;
                        case "Reddit": salary -= 50;
                            if (salary <= 0)
                            {
                                tabs = 0;
                                Console.WriteLine("You have lost your salary.");
                            }
                            break;
                    }
                }
               
            }
           
            if (salary > 0)
            {
                Console.WriteLine(Math.Round(salary));
            }
            //else if (salary <= 0)
            //{

            //    Console.WriteLine("You have lost your salary.");
            //}
        }
    }
}
