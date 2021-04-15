using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _2.FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
          
            string paternBar = @"^@#+([A-Z][A-Za-z0-9]{4,}[A-Z])@#+$";
            // 80 string paternBar = @"^(@#+)([A-Z]{1}[A-Za-z0-9]{4,}[A-Z{}])(\1)$";
            //string paternBar = @"^(@#+)([A-Z[a-z0-9]{4,}[A-Z])(\1)$";
            Regex barcodReg = new Regex(paternBar);
            string patermDig = @"\d";
            Regex digits = new Regex(patermDig);
            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                Match match = barcodReg.Match(input);
                if (match.Success)
                {

                    string numb = string.Empty;
                    MatchCollection numCollect = digits.Matches(input);
                    if (numCollect.Count > 0)
                    {
                        foreach (Match item in numCollect)
                        {
                            numb += item.ToString();
                        }
                    }
                    else
                    {
                        numb = "00";
                    }
                    Console.WriteLine($"Product group: {numb}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }


            }
        }
    }
}
