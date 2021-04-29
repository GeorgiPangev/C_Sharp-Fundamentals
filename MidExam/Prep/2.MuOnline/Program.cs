using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            
            int hp = 100;
            int bit = 0;
            bool killed = false;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].Contains("potion"))
                {
                    string heal = input[i].Remove(0, 7); 
                    int health = int.Parse(heal);
                    if (hp+health<=100)
                    {
                        hp = hp + health; 
                        Console.WriteLine($"You healed for {health} hp.");
                        Console.WriteLine($"Current health: {hp} hp.");
                    }
                    else
                    {
                        int hpPlus =(hp + health) - 100;
                        hpPlus = health - hpPlus;
                        hp = 100;
                        Console.WriteLine($"You healed for {hpPlus} hp.");
                        Console.WriteLine($"Current health: {hp} hp.");
                    }
                }
                if (input[i].Contains("chest"))
                {
                    int coins = int.Parse(input[i].Remove(0, 6));
                    bit += coins;
                    Console.WriteLine($"You found {coins} bitcoins.");
                }
                if (!input[i].Contains("chest")&!input[i].Contains("potion"))
                {
                    List<string> txt = input[i].Split(" ").ToList();
                    int dmg = int.Parse(txt[1]);
                    hp -= dmg;
                    if (hp>0)
                    {
                        Console.WriteLine($"You slayed {txt[0]}.");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {txt[0]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        killed = true;
                        break;

                    }
                }

            }
            switch (killed)
            {
                case false:
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Bitcoins: {bit}");
                    Console.WriteLine($"Health: {hp}");
                    break;

            }

        }
    }
}
