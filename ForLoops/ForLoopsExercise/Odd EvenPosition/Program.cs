using System;

namespace _03.Odd_EvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            double repeets = Double.Parse(Console.ReadLine());

            double oddSum = 0.0;
            double oddMin = double.MaxValue;//" + { минимална стойност на числата на нечетни позиции } / {“No”},
            double oddMax = double.MinValue;//" + { максимална стойност на числата на нечетни позиции } / {“No”},
            double evenSum = 0.0; //" + { сума на числата на четни позиции },
            double evenMin = double.MaxValue;//" + { минимална стойност на числата на четни позиции } / {“No”},
            double evenMax = double.MinValue;//" + { максимална стойност на числата на четни позиции } / {“No”}

            for (int i = 1; i <= repeets ; i++)
            {
                double num = Double.Parse(Console.ReadLine());

                if (i % 2 == 0  )
                {
                    evenSum += num;
                    if (num > evenMax)
                    {
                        evenMax = num;
                    }
                    if (num < evenMin)
                    {
                        evenMin = num;
                    }
                }
                if (i % 2 != 0  )
                {
                    oddSum += num;
                    if (num > oddMax)
                    {
                        oddMax = num;
                    }
                    if (num < oddMin)
                    {
                        oddMin = num;
                    }
                }

            }
            if (oddSum != 0)
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine($"OddMin={oddMin:F2},");
                Console.WriteLine($"OddMax={oddMax:F2},");
            }
            else
            {
                Console.WriteLine($"OddSum={oddSum:F2},");
                Console.WriteLine("OddMin=No,");
                Console.WriteLine("OddMax=No,");
            }
            if (evenSum != 0)
            {
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine($"EvenMin={evenMin:F2},");
                Console.WriteLine($"EvenMax={evenMax:F2}");
            }
            else
            { 
                Console.WriteLine($"EvenSum={evenSum:F2},");
                Console.WriteLine("EvenMin=No,");
                Console.WriteLine("EvenMax=No");
            }
        }
    }
}
