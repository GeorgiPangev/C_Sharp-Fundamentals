using System;

namespace Hosptal
{
    class Program
    {
        static void Main(string[] args)
        {
            Double days = Double.Parse(Console.ReadLine());

            Double doc = 7;
            Double ptchek = 0;
            Double ptunchek = 0;
            Double unchektwoDays = 0;

            for (Double i = 1; i <= days; i++)
            {
                Double pt = Double.Parse(Console.ReadLine());
                if (i % 3 == 0 && unchektwoDays > 0)
                {
                    doc += 1;
                    unchektwoDays = 0;
                }

                if (doc <= pt)
                {
                    ptchek += doc;
                    ptunchek += pt - doc;
                    unchektwoDays += ptunchek;
                }
                else if (doc > pt)
                {
                    ptchek += pt;
                }
            }       
            Console.WriteLine($"Treated patients: {ptchek}.");
            Console.WriteLine($"Untreated patients: {ptunchek}.");
        }
    }
}
