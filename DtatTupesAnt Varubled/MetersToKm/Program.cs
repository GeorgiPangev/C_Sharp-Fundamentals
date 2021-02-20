using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics.X86;

namespace MetersToKm
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            long leftSum = 0;
            long rightSum = 0;
            bool IsSpaseFound = false;


            for (int i = 1; i <= lines; i++)
            {
                IsSpaseFound = false;
                leftSum = 0;
                rightSum = 0;
                string input = Console.ReadLine();
                for (int j = 0; j < input.Length; j++)
                {
                    char r = (input[j]);

                    if (r == ' ')
                    {
                        IsSpaseFound = true;
                        continue;
                    }
                    else if (r == '-')
                    {
                        continue;
                    }

                    int digit = int.Parse(r.ToString());
                    // int digit = 0;
                    //if (int.TryParse(input[j].ToString(), out digit))
                    //{


                    if (!IsSpaseFound)
                    {


                        leftSum += digit;
                    }
                    else if (IsSpaseFound)
                    {

                        rightSum += digit;
                    }
                    //}
                }
                long bigestSum = Math.Max(leftSum, rightSum);
                Console.WriteLine(bigestSum);
                // if (leftSum>=rightSum)
                //{
                //    Console.WriteLine(leftSum);

                //}
                //else if (rightSum>leftSum)
                //{
                //    Console.WriteLine(rightSum);
                //}

            }

        }

    }
}
