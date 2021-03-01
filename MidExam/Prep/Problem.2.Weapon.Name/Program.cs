using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem._2.Weapon.Name
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                 .Split("|", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string[] comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (comand[0]!= "Done")
            {
                
                if (comand[1]== "Left")
                {
                    bool isPosible = Posible(comand, input);

                    if (isPosible)
                    {
                        int x = int.Parse(comand[2]);
                        string move = input[x];
                        string save = input[x - 1];
                        //input.Remove(move);
                        input[x - 1]=  move;
                        input[x]=  save;
                    }
                }
                else if (comand[1] == "Right")
                {
                    bool isPosible = Posible(comand, input);
                    if (isPosible)
                    { 

                        int x = int.Parse(comand[2]);
                        string move = input[x];
                        string save = input[x + 1];
                        input.Remove(move);
                        input.Insert(x + 1, move);
                       // input[x+1] = move;
                        //input[x] = save;
                    }
                }
                else if (comand[0]== "Check")
                {
                    string ch = Checked(comand, input);
                    Console.WriteLine($"{ch}");
                }
                comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            }
            Console.WriteLine($"You crafted {string.Join("", input)}!");
        }

        private static string Checked(string[] comand, List<string> input)
        {
            StringBuilder str = new StringBuilder();
            if (comand[1]== "Odd")
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (i%2==1)
                    {
                        str.Append(input[i] + " ");
                    }
                }
                return str.ToString();
            }
            else
            {
                for (int i = 0; i < input.Count; i++)
                {
                    if (i % 2 == 0)
                    {
                        str.Append(input[i] + " ");
                    }
                   
                }
                return str.ToString();



            }
        }
                
        public static bool Posible(string[] comand, List<string> input)
        {
            int x = int.Parse(comand[2]);
            if (comand[1] == "Left" && (x >= 1 && x < input.Count - 1))
            {
                return true;
            }
            else if (comand[1] == "Right" && (x >= 0 && x <= input.Count - 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
