using System;
using System.Linq;
using System.Text;

namespace _1.ActivationKeys
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = input;
            string[] comand = Console.ReadLine()
                .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (comand[0]!= "Generate")
            {
                switch (comand[0])
                {
                    case "Flip":
                        result = FlipString(result, comand);
                        Console.WriteLine(result);
                        break;

                    case "Slice":
                        result = SliceString(result, comand);
                        Console.WriteLine(result);
                        break;
                    case "Contains":

                        if (result.Contains(comand[1]))
                        {
                            Console.WriteLine($"{result} contains {comand[1]}");
                        }
                        else
                        {
                            Console.WriteLine("Substring not found!");
                        }
                        break;
                }

                comand = Console.ReadLine()
                .Split(">>>", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            Console.WriteLine($"Your activation key is: {result}");
        }

        private static string SliceString(string result, string[] comand)
        {
            string tempStr = result;
            int startInd = int.Parse(comand[1]);
            
            int count = int.Parse(comand[2]) - startInd;
            tempStr=  tempStr.Remove(startInd, count);
            return tempStr;
        }

        private static string FlipString(string result, string[] comand)
        {
            StringBuilder bild = new StringBuilder();
            string tempStr = result;
            int startInd = int.Parse(comand[2]);
            int endInd = int.Parse(comand[3])-1;
            string act = comand[1];
            for (int i = startInd; i <= endInd; i++)
            {
                bild.Append(result[i]);
            }
            int count = int.Parse(comand[3]) - startInd;
            tempStr= tempStr.Remove(startInd, count);
            if (act == "Upper")
            {
                tempStr= tempStr.Insert(startInd, bild.ToString().ToUpper());
            }
            else if (act == "Lower")
            {
                tempStr = tempStr.Insert(startInd, bild.ToString().ToLower());
            }
            return tempStr;
        }
    }
}
