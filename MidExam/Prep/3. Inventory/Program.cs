using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inventory = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string input = Console.ReadLine();
            while (input != "Craft!")
            {
                string[] com = input.Split(" - ").ToArray();
                if (input.Contains("Combine"))
                {

                    input = input.Remove(0, 16);
                    string[] comand = input.Split(":").ToArray();
                    if (inventory.Contains(comand[0]))
                    {
                        inventory.Remove(comand[1]);
                        int indexOfOld = inventory.IndexOf(comand[0]);
                        inventory.Insert(indexOfOld + 1, comand[1]);

                    }
                }
                else if (com[0] == "Collect")
                {
                    if (inventory.Contains(com[1]) == false)
                    {
                        inventory.Add(com[1]);
                    }
                }
                else if (com[0] == "Drop")
                {
                    if (inventory.Contains(com[1]))
                    {
                        inventory.Remove(com[1]);
                    }
                }
                else if (com[0] == "Renew")
                {
                    if (inventory.Contains(com[1]))
                    {
                        inventory.Remove(com[1]);
                        inventory.Add(com[1]);
                    }
                }
                input = Console.ReadLine();


            }
            Console.WriteLine(string.Join(", ", inventory));
        }
    }
}
