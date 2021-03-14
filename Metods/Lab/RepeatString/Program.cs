using System;
using System.Text;

namespace RepeatString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());

            string toPrintStr = StrByN(input, n);
            Console.WriteLine(toPrintStr);
        }
        private static string StrByN(string input, int n)
        {
            StringBuilder done = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                done.Append(input);
                
               

            }
            return done.ToString();

        }

       
    }
}
