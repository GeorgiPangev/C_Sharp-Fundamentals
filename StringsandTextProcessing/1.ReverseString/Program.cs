using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string reverse = "";
            while (input != "end")
            {

                //input = Console.ReadLine();



                for (int i = input.Length - 1; i >= 0; i--)
                {
                    //string n = input[i].Reverse
                    reverse += input[i];
                }
                Console.WriteLine($"{input} = {reverse}");
                reverse = "";
                input = Console.ReadLine();
               
            }
           

        }
    }
}
