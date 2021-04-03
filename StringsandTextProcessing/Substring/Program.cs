using System;
using System.Text;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string toRem = Console.ReadLine().ToLower();
            string input = Console.ReadLine().ToLower();

           
            while (input.Contains(toRem))
            {
                    int n = input.IndexOf(toRem) ;
                    input = input.Remove(n, toRem.Length);
             }
            
            Console.WriteLine(input);
        }
    }
}
