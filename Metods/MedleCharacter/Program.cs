using System;
using System.Linq;

namespace MedleCharacter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            PrintMidel(input);
               
        }
        private static void PrintMidel(string abc)
        {
            int midLeng = abc.Length;
            if (abc.Length%2!=0)
            {
                midLeng = ((abc.Length - 1) / 2) ;
                Console.WriteLine(abc[midLeng]);
            }
            else
            {
                midLeng = (abc.Length / 2)-1;
                Console.WriteLine($"{abc[midLeng]}{abc[midLeng+1]}");
            }
        }
    }
}
