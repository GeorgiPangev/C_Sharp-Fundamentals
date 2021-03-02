using System;

namespace _4Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Double n = double.Parse(Console.ReadLine());

            double p1 = 0; //<200
            double p2 = 0; // 200 - 399
            double p3 = 0; // 400 - 599
            double p4 = 0; // 600 - 799
            double p5 = 0; // >= 800
            //Дадени са n цели числа в интервала[1…1000].От тях някакъв процент
            //    p1 са под 200, друг процент p2 са от 200 до 399, друг процент p3 
            //    са от 400 до 599, друг процент p4 са от 600 до 799 и останалите p5 
            //    процента са от 800 нагоре.Да се напише програма, която изчислява и 
            //    отпечатва процентите p1, p2, p3, p4 и p5.

            for (int i = 1; i <= n ; i++)
            {
                double num = double.Parse(Console.ReadLine());
                if (num < 200)
                {
                    p1 += 1;
                }
                else if (num >=200 && num <=399)
                {
                    p2 += 1;
                }
                else if (num >= 400 && num <= 599)
                {
                    p3 += 1;
                }
                else if (num >= 600 && num <= 799)
                {
                    p4 += 1;
                }
                else if (num >= 800)
                {
                    p5 += 1;
                }
               
            }
            double numSum = p1 + p2 + p3 + p4 + p5;
            
            Console.WriteLine($"{((p1 / numSum) * 100):F2}%");
            Console.WriteLine($"{((p2 / numSum) * 100):F2}%");
            Console.WriteLine($"{((p3 / numSum) * 100):F2}%");
            Console.WriteLine($"{((p4 / numSum) * 100):F2}%");
            Console.WriteLine($"{((p5 / numSum) * 100):F2}%");

        }
    }
}
