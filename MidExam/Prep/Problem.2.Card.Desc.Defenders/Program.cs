using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem._2.Card.Desc.Defenders
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baseDeck = Console.ReadLine()
                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<string> deck = new List<string>(baseDeck.Length);
            string[] comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (comand[0]!="Ready")
            {
                if (comand[0]== "Swap")
                {
                    if (baseDeck.Contains(comand[1])&& baseDeck.Contains(comand[2]))
                    {
                        int swapOneInd = deck.IndexOf(comand[1]);
                        int swapTwoInd = deck.IndexOf(comand[2]);
                        deck[swapOneInd] = comand[2];
                        deck[swapTwoInd] = comand[1];
                    }
                }
                else if (comand[0]== "Insert")
                {
                    if (baseDeck.Contains(comand[1]) &&
                        (int.Parse(comand[2])>=0&&int.Parse(comand[2])<deck.Count))
                    {

                        deck.Remove(comand[1]);
                        deck.Insert(int.Parse(comand[2]), comand[1]);

                    }
                    else
                    {
                        Console.WriteLine("Error!");
                    }
                }
                else if (comand[0]== "Remove")
                {
                    if (baseDeck.Contains(comand[1])&& deck.Contains(comand[1]))
                    {
                        deck.Remove(comand[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (comand[0]== "Add")
                {
                    if (baseDeck.Contains(comand[1]))
                    {
                        deck.Remove(comand[1]);
                        deck.Add(comand[1]);
                    }
                    else
                    {
                        Console.WriteLine("Card not found.");
                    }
                }
                else if (comand[0]== "Shuffle")
                {
                    deck.Reverse();
                }
               

                comand = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
            if (deck.Count>0)
            {
               
                Console.Write(string.Join(" ", deck));
            }

          


        }

    
    }
}
