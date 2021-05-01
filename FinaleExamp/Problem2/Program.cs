using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());
            //MatchCollection matces = new MatchCollection;
            string patren = @"(\*?@?)(?<tag>[A-Z][a-z]{2,})(\1):\s\[(?<one>\w)]\|\[(?<two>\w)]\|\[(?<three>\w)]\|$";
            Regex reg = new Regex(patren);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                MatchCollection nm = reg.Matches(input);
                
                Match mach = reg.Match(input);
                if (mach.Success)
                {
                    string tag = mach.Groups[3].ToString();
                    char a = char.Parse(mach.Groups[4].ToString());
                    char b = char.Parse(mach.Groups[5].ToString());
                    char c = char.Parse(mach.Groups[6].ToString());
                    int one = (char)a;
                    int two = (char)b;
                    int three = (char)c;

                    Console.WriteLine($"{tag}: {one} {two} {three}");

                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }

            }
           
        }
    }
}
