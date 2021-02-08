using System;

namespace ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            // •	Пъзел - 2.60 лв.
            //•	Говореща кукла -3 лв.
            //•	Плюшено мече -4.10 лв.
            //•	Миньон - 8.20 лв.
            //•	Камионче - 2 лв.

            //                Ако поръчаните играчки са 50 или повече магазинът прави отстъпка 25 % от общата цена. От спечелените пари Петя трябва да даде 10 % за наема на магазина.Да се пресметне дали парите ще ѝ стигнат да отиде на екскурзия.
            //        От конзолата се четат 6 реда:
            //1.Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //2.Брой пъзели - цяло число в интервала[0… 1000]
            //3.Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //4.Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //5.Брой миньони - цяло число в интервала[0 … 1000]
            //6.Брой камиончета - цяло число в интервала[0 … 1000]
            //        На конзолата се отпечатва:
            //•	Ако парите са достатъчни се отпечатва:
            //            o   "Yes! {оставащите пари} lv left."
            //•	Ако парите НЕ са достатъчни се отпечатва:
            //            o   "Not enough money! {недостигащите пари} lv needed."

            Double turPrice = double.Parse(Console.ReadLine());
            Double puzzelNum = Double.Parse(Console.ReadLine());
            Double dolesNum = Double.Parse(Console.ReadLine());
            Double bearsNum = Double.Parse(Console.ReadLine());
            Double minionsNum = Double.Parse(Console.ReadLine());
            Double TrucksNum = Double.Parse(Console.ReadLine());

            Double ToysSum = puzzelNum + dolesNum + bearsNum + minionsNum + TrucksNum;
            Double TotalIncom = (puzzelNum * 2.60) + (dolesNum * 3) + (bearsNum * 4.10) + (minionsNum * 8.20) + (TrucksNum * 2);


            if (ToysSum >= 50)
            {
                Double TotalIncom2 = TotalIncom - (TotalIncom * 0.25);
                Double TotalIncom3 = TotalIncom2 - (TotalIncom2 * 0.10);
                double clear = TotalIncom3 - turPrice;

                if (clear >= 0)
                {
                    Console.WriteLine( "Yes! " + ($"{(clear) :F2}") + " lv left.");
                }
                else
                {
                    Console.WriteLine("Not enough money! " + ($"{Math.Abs(clear):F2}") + " lv needed.");
                }
            }
            else
            {
                Double TotalIncom2 = TotalIncom - (TotalIncom * 0.10);
                double clear = TotalIncom2 - turPrice;

                if (clear >= 0)
                {
                    Console.WriteLine("Yes! " + ($"{ (clear) :F2}") + " lv left.");
                }
                else
                {
                    Console.WriteLine("Not enough money! " + ($"{ Math.Abs(clear) :F2}") + " lv needed.");
                }
            }



            }
    }
}
