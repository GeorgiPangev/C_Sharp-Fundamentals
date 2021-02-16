using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Town> towns = new List<Town>();
            string input = Console.ReadLine();
            while (input != "Sail")
            {
                string[] newtoln = input.Split("||", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Town fod = towns.FirstOrDefault(x => x.Name == newtoln[0]);
                if (fod == null)
                {
                    Town newTown = new Town();
                    newTown.TownAdd(newtoln[0], int.Parse(newtoln[1]), int.Parse(newtoln[2]));
                    towns.Add(newTown);
                }
                else
                {
                    int n = towns.IndexOf(fod);
                    towns[n].Populatione += int.Parse(newtoln[1]);
                    towns[n].Gold += int.Parse(newtoln[2]);
                }


                input = Console.ReadLine();
            }

            string comand = Console.ReadLine();
            while (comand != "End")
            {
                string[] com = comand.Split("=>", StringSplitOptions.RemoveEmptyEntries).ToArray();
                Town furst = towns.FirstOrDefault(x => x.Name == com[1]);
                int ind = towns.IndexOf(furst);
                if (com[0] == "Plunder")
                {
                    towns[ind].Populatione -= int.Parse(com[2]);
                    towns[ind].Gold -= int.Parse(com[3]);
                    Console.WriteLine($"{com[1]} plundered! {com[3]} gold stolen, {com[2]} citizens killed.");
                    if (towns[ind].Populatione <= 0 || towns[ind].Gold <= 0)
                    {
                        Console.WriteLine($"{towns[ind].Name} has been wiped off the map!");
                        towns.Remove(towns[ind]);
                        
                    }
                }
                else if (com[0] == "Prosper")
                {
                    int goldToAdd = int.Parse(com[2]);
                    if (goldToAdd > 0)
                    {

                        towns[ind].Gold += goldToAdd;
                        Console.WriteLine($"{goldToAdd} gold added to the city treasury. " +
                            $"{towns[ind].Name} now has {towns[ind].Gold} gold.");
                    }
                    else //if (goldToAdd < 0)
                    {
                        Console.WriteLine($"Gold added cannot be a negative number!");
                    }

                }

                comand = Console.ReadLine();
                
            }

            if (towns.Count > 0)
            {
                Console.WriteLine($"Ahoy, Captain! There are {towns.Count} wealthy settlements to go to:");
                PrintTowns(towns);
            }
           
            else 
            {
                Console.WriteLine($"Ahoy, Captain! All targets have been plundered and destroyed!");
            }

        }

        private static void PrintTowns(List<Town> towns)
        {
            foreach (Town toln in towns.OrderByDescending(x=>x.Gold).ThenBy(x=>x.Name))
            {
                Console.WriteLine(toln.ToString());
            }
        }
    }
    class Town
    {
        public void TownAdd(string name, int pop, int gold)
        {
            Name = name;
            Populatione = pop;
            Gold = gold;
        }
        public string Name { get; set; }
        public int Populatione { get; set; }
        public int Gold { get; set; }

        public override string ToString()
        {
            string print = $"{Name} -> Population: {Populatione} citizens, Gold: {Gold} kg";
            return print;
        }
    }
}
