using System;
using System.Linq;

namespace StringAndCharsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            string alfa = "abcdefghijklmnopqrstuvwxyz";
            double sum = 0;

            foreach (var item in input)
            {
                char firstChar = item[0];
                char secondChar = item[item.Length-1];
                double num = double.Parse(item.Substring(1, (item.Length - 2)));
                double firstNumb = alfa.IndexOf(char.ToLower(firstChar))+1;
                double secondNumb  = alfa.IndexOf(char.ToLower(secondChar))+1;
                double betwin = 0;

                if (firstChar > 90)
                {
                    betwin = num * firstNumb;
                }
                else
                {
                    betwin += num / firstNumb;
                }

                if (secondChar>90)
                {
                    betwin += secondNumb;
                }
                else
                {
                    betwin -= secondNumb;
                }
                sum += betwin;


            }
            Console.WriteLine($"{sum:F2}");
        }
    }
}
