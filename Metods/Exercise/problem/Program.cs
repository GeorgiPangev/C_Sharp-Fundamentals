using System;
using System.Linq;

namespace problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string[] arr = str
               //.Replace('', ' ')

                .Split("")
               // .Select(int.Parse)
                //.Select(int.Parse)
                .ToArray();

            Console.WriteLine(string.Join("+",arr));
            Console.WriteLine(arr.Length);
        }
    }
}
