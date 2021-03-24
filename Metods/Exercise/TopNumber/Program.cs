using System;
using System.Linq;
using System.Text;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            StringBuilder str = new StringBuilder();
            string[] topNums = DefindingInStr(x, str)
                .Split(" ")
                .ToArray();
            PrintArr(topNums);


        }

        private static void PrintArr(string[] topNums)
        {
            foreach (var item in topNums)
            {
                Console.WriteLine(item);
            }
        }

        private static string DefindingInStr(int n, StringBuilder curentStr)
        {
            curentStr = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
               
                int sumofdigits = 0;
                bool isOddDigit = false;
                int digit = i;
                while (digit>=1)
                {
                    int curDigit = digit% 10;

                    sumofdigits += curDigit;
                    if (curDigit%2!=0)
                    {
                        isOddDigit = true;
                    }

                    digit /= 10;

                }
                if (isOddDigit&& sumofdigits%8==0)
                {
                    curentStr.Append(i + " ");
                    
                }
            }
            return curentStr.ToString();
        }
    }
}
