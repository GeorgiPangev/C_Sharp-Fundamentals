using System;
using System.Linq;
using System.Text;

namespace MultuplyBigNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string big = Console.ReadLine().TrimStart('0');
            
            int multipl = int.Parse(Console.ReadLine());

            if (multipl <1|| big=="")
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder result = new StringBuilder();

            int rest = 0;
            for (int i = big.Length-1; i >= 0; i--)
            {
                int res = (multipl * (int.Parse(big[i].ToString()))) + rest;
                int tostrei = (res % 10);
                rest = res / 10;

                result.Insert(0, tostrei);
            }
            if (rest>0)
            {
                result.Insert(0, rest);
            }
            Console.WriteLine(result.ToString());
        }
    }
}
