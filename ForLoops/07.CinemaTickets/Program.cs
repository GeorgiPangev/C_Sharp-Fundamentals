using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double free = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            double studentType = 0;
            double standardTypt = 0;
            double kidType = 0;
            double ticetsForName = 0;
            double count = 0;
            bool gotfin = false;
            

            while (name != "Finish")
            {
                while (type != "End")
                {
                    
                    if (type == "student")
                    {
                        studentType++;
                        count++;
                        ticetsForName++;
                    }
                    else if (type == "standard")
                    {
                        standardTypt++;
                        ticetsForName++;
                        count++;
                    }
                    else if (type == "kid")
                    {
                        kidType++;
                        ticetsForName++;
                        count++;
                    }

                   
                    if (ticetsForName >= free)
                    {
                        //Console.WriteLine($"{name} - {((ticetsForName / free) * 100):F2}% full.");
                        break;
                    }
                    if (type == "End") { break; }

                    if (type == "Finish") //& type == "finish")
                    {
                          gotfin = true;
                        //Console.WriteLine($"{name} - {((ticetsForName / free) * 100):F2}% full.");
                        break;
                    }
                    type = Console.ReadLine();

                }
                Console.WriteLine($"{name} - {((ticetsForName / free) * 100):F2}% full.");

                if (gotfin)
                {
                    break;
                }
                type = "";
               
                ticetsForName = 0;
                //if (name == "Finish") { break; }
                //if (name == "End") { break; }
                name = Console.ReadLine();
                if (name == "Finish") { break; }
                if (name == "End") { break; }
                free = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total tickets: {count}");
            double one = (studentType / count) * 100;
            double two = (standardTypt / count) * 100;
            double tree = (kidType / count) * 100;
            Console.WriteLine($"{one :F2}% student tickets.");
            Console.WriteLine($"{two :F2}% standard tickets.");
            Console.WriteLine($"{tree :F2}% kids tickets.");
        }   
    }
}
