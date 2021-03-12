using System;
using System.Linq;

namespace MultiplyEvenByOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = Console.ReadLine()
            //    .Replace("-","")
            //    .Replace("", "!")
            //    .Split("!")
            //    .Select(int.Parse)
            //    .ToArray();
            string input = Console.ReadLine()
                .Replace("-", "");

            int[] arr = new int[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                //int n = 
                arr[i] = int.Parse(input[i].ToString());
            }



            int evenSum = EvenSum(arr);
            int oddSum = OddSum(arr);
            Console.WriteLine(FinaleSum(evenSum, oddSum));

        }

        private static int FinaleSum(int evenSum, int oddSum)
        {
            return evenSum * oddSum;
        }

        private static int OddSum(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
               
                if (item%2!=0)
                {
                    sum += item;

                }
               
            }
            return sum;
        }

        private static int EvenSum(int[] arr)
        {
            int sum = 0;
            foreach (int item in arr)
            {
                if (item%2==0)
                {
                    sum += item;
                }
            }
            return sum;
        }
    }
}
