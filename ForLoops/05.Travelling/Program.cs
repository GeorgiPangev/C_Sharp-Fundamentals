using System;

namespace _05.Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string dest = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            double incomCount = 0;
            bool isenof = false;
            bool breked = false;
            double sumneeded = 0;

            while (dest != "End")
            {
                if (breked)
                {
                    break;
                }
                if (isenof)
                {
                    dest = Console.ReadLine();
                    if (dest == "End")
                    {
                        
                        break;
                    }
                    price = double.Parse(Console.ReadLine());
                    incomCount = 0; isenof = false;
                }
                string inc = Console.ReadLine();
                double incom = double.Parse(inc);
                incomCount+= incom;
                for (double i = 0; i < price; i+= incom)
                {

                   
                   
                    if (incomCount>= price)
                    {
                        Console.WriteLine($"Going to {dest}!");
                        isenof = true;
                        break;
                    }
                    inc = Console.ReadLine();
                    if (inc == "End")
                    {
                        breked = true;
                        break;
                    }
                    incom = double.Parse(inc);
                    incomCount += incom;

                }
            }
        }
    }
}
