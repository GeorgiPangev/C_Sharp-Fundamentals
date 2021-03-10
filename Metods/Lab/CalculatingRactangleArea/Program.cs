using System;

namespace CalculatingRactangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double hight = double.Parse(Console.ReadLine());
            //double area =0;
            //CalculateArea(width, hight);
            Console.WriteLine(CalculateArea(width, hight));
        }
        static double CalculateArea(double w, double h)
        {


            return w * h; ;
        }
    }
}
