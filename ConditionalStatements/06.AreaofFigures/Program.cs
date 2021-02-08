using System;

namespace _06.AreaofFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Да се напише програма, в която потребителят въвежда вида и размерите на геометрична фигура и пресмята лицето й.Фигурите са четири вида: квадрат(square), правоъгълник(rectangle), кръг(circle) и триъгълник(triangle). На първия ред на входа се чете вида на фигурата(square, rectangle, circle или triangle).
            //•	Ако фигурата е квадрат, на следващия ред се чете едно число -дължина на страната му.
            //•	Ако фигурата е правоъгълник, на следващите два реда четат две числа -дължините на страните му.
            //•	Ако фигурата е кръг, на следващия ред чете едно число - радиусът на кръга.
            //•	Ако фигурата е триъгълник, на следващите два реда четат две числа -дължината на страната му и дължината на височината към нея.
            //Резултатът да се закръгли до 3 цифри след десетичната точка.
            // (square, rectangle, circle или triangle

            String figur = Console.ReadLine();

            if ((figur) == "square")
            {
                Double x = Double.Parse(Console.ReadLine());

                Console.WriteLine($"{(x) * (x) :F3}");
            }
            else if ((figur) == "rectangle")
            {
                Double x = Double.Parse(Console.ReadLine());
                Double y = Double.Parse(Console.ReadLine());

                Console.WriteLine($"{ (x) * (y) :F3} " );
            }
            else if ((figur) == "circle")
            {
                Double x = Double.Parse(Console.ReadLine());
                Console.WriteLine($"{Math.PI*((x) * (x)) :F3}");
            }
            else if ((figur) == "triangle")
            {
                Double x = Double.Parse(Console.ReadLine());
                Double y = Double.Parse(Console.ReadLine());

                Console.WriteLine($"{((x) * (y)) / 2 :F3}");
            }


        }
    }
}
