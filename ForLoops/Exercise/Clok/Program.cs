using System;

namespace Clok
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = 0;
            int m = 0;
            int s = 0;
            while (h<=23)
            {
                if (s == 60)
                {
                    m++;
                    s = 0;

                }
                if (m  == 60)
                {
                    h += 1;
                    m = 0;
                }
                if (h == 24)
                { break; }
               
                Console.WriteLine(h +" : "+ m + " : " + s);
                s += 1;


            }
        }
    }
}
