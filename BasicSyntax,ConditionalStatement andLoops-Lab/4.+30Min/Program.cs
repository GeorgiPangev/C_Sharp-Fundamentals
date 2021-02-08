using System;

namespace _4._30Min
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());

            m += 30;
            if (m>59)
            {
                h++;
                m -= 60;
            }
            if (h>23)
            {
                h = 0;
            }
            Console.WriteLine($"{h}:{m:D2}");
        }

    }
}
