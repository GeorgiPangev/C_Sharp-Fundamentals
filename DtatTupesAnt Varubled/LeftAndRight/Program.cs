using System;
using System.Linq;

namespace LeftAndRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            

            for (int i = 1; i <= lines; i++)
            {
                var input = Console.ReadLine();
                string[] arr = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                
                //int[] intArr = arr.Select(int.Parse).ToArray();
                long lSum = 0;
                long rSum = 0;
                bool isMinus = false;

                string left = arr[0];
                string rigt = arr[1];
                for (int j = 0; j < left.Length; j++)
                {
                    char r = char.Parse(arr[j].ToString());
                    if (isMinus)
                    {
                        lSum -= int.Parse(left[j].ToString());
                        isMinus = false;
                        continue;
                    }
                    if (r == '-')
                    {
                        isMinus = true;
                        continue;
                    }
                   
                    lSum += int.Parse(left[j].ToString());
                }
                for (int j = 0; j < rigt.Length; j++)
                {
                    char r = ((char)j);
                    if (isMinus)
                    {
                        rSum -= int.Parse(rigt[j].ToString());
                        isMinus = false;
                        continue;
                    }
                    if (r == '-')
                    {
                        isMinus = true;
                        continue;
                    }
                    rSum += int.Parse(rigt[j].ToString());
                }
                long BigestNum = Math.Max(lSum, rSum);
                Console.WriteLine(BigestNum);



            }
           
        }
    }
}
