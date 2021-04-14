using System;
using System.Linq;
using System.Text;

namespace _1.PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string com = Console.ReadLine();
            while (com!="Done")
            {
                string[] comands = com.Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string x = comands[0];
                if (comands[0]=="Cut")
                {
                    int ind = int.Parse(comands[1]);
                    int leng = int.Parse(comands[2]);
                    input = CutIt(input, ind, leng);
                    Console.WriteLine(input);
                }
                else if (comands[0]=="TakeOdd")
                {
                    input = TakeOdd(input);
                    Console.WriteLine(input);
                }
                else if (comands[0]== "Substitute")
                {
                    if (input.Contains(comands[1]))
                    {
                        input = input.Replace(comands[1], comands[2]);
                        Console.WriteLine(input);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                    }
                    
                }
                com = Console.ReadLine();
            }
            Console.WriteLine($"Your password is: {input}");
        }

        private static string TakeOdd(string input)
        {
            StringBuilder str = new StringBuilder();
            for (int i = 1; i < input.Length; i+=2)
            {
                //if (i % 2 == 1)
                //{
                    str.Append(input[i]);
                //}
            }
            return str.ToString();
        }

        private static string CutIt(string input, int ind, int leng)
        {
            string result = input.Substring(ind, leng);
            if (input.Contains(result))
            {
                int i = input.IndexOf(result);
                input = input.Remove(i, leng);
            }

            return input;
        }
    }
}
