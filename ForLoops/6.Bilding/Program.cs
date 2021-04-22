using System;

namespace _6.Bilding
{
    class Program
    {
        static void Main(string[] args)
        {
            int flors = int.Parse(Console.ReadLine());
            int rooms = int.Parse(Console.ReadLine());
            string roll = "";

            for (int f = flors; f >=1  ; f--)
            {
                for (int r = 0; r < rooms ; r++)
                {
                    if (f == flors)
                    {
                        roll += $"L{f}{r} ";
                        //Console.WriteLine($"L{f}{r}");
                    }
                    else if (f % 2 == 0)
                    {
                        roll += $"O{f}{r} ";
                        // Console.WriteLine($"O{f}{r}");
                    }
                    else if (f % 2 != 0)
                    {
                        roll += $"A{f}{ r} ";
                        //Console.WriteLine($"A{f}{r}");
                    }
                    if (r== rooms -1)
                    {
                        Console.WriteLine(roll);
                        roll = "";
                        
                    }
                }
            }
        }
    }
}
