using System;
using System.Linq;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            while (input[0]!= "End")
            {
                string com = input[0];
                if (com == "Translate")
                {
                    char oldCh = char.Parse(input[1]);
                    char newCh = char.Parse(input[2]);
                    str = str.Replace(oldCh, newCh);
                    Console.WriteLine(str);
                }
                else if (com == "Includes")
                {
                    string contenst = input[1];
                    //if ()
                    //{
                        Console.WriteLine(str.Contains(contenst));
                   // }
                }
                else if (com == "Start")
                {
                    string check = input[1];
                    if (str.Length >= check.Length)
                    {
                        string starter = str.Substring(0, check.Length);
                        Console.WriteLine(starter== check);
                    }
                    else
                    {
                        Console.WriteLine(false);
                    }
                }
                else if (com == "Lowercase")
                {
                    str = str.ToLower();
                    Console.WriteLine(str);
                }
                else if (com == "FindIndex")
                {
                   
                    char ch = char.Parse(input[1]);
                    if (str.Contains(ch))
                    {
                        int x = str.LastIndexOf(ch);
                        Console.WriteLine(x);
                    }
                }
                else if (com == "Remove")
                {
                    
                    int startInd = int.Parse(input[1]);
                    int count = int.Parse(input[2]);
                    if (IsValid(startInd, count, str.Length))
                    {
                        str = str.Remove(startInd, count);
                        Console.WriteLine(str);
                    }
                    
                   
                }


                input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            }
            

        }

        private static bool IsValid(int s, int c, int l)
        {

            return (s >= 0 && s < l) && (c > 0 && c < l);
            
            

        }
    }
}
