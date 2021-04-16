using System;
using System.Collections.Generic;
using System.Linq;

namespace _3.HeroesofCodeandLogicVII
{
    class Hero
    {
        public void hero(string name, int hp, int mp)
        {
            Name = name;
            Hp = hp;
            Mp = mp;

        }
        public string Name { get; set; }
        public int Hp { get; set; }
        public int Mp { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name}");
            Console.WriteLine($"  HP: {Hp}");
            Console.WriteLine($"  MP: {Mp}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Hero> heros = new List<Hero>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] newH = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string name = newH[0];
                int hp = int.Parse(newH[1]);
                int mp = int.Parse(newH[2]);
                Hero newHero= new Hero(); 
                  newHero.hero(name, hp, mp); 
                heros.Add(newHero);

            }
            string[] input = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            while (input[0]!= "End")
            {
                string nameOf = input[1];
                Hero h = heros.Find(x => x.Name == nameOf);
                int ind = heros.IndexOf(h);
                int manaHave = heros[ind].Mp;
                int healtHave = heros[ind].Hp;
                if (input[0]=="CastSpell")
                {
                    //CastSpell – {hero name} – {MP needed} – {spell name} 
                    int nededM = int.Parse(input[2]);
                    
                    if (manaHave>=nededM)
                    {
                        manaHave -= nededM;
                        heros[ind].Mp = manaHave;
                        Console.WriteLine($"{heros[ind].Name} has successfully cast" +
                            $" {input[3]} and now has {heros[ind].Mp} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{heros[ind].Name} does not have " +
                            $"enough MP to cast {input[3]}!");
                    }
                    
                  
                }
                else if (input[0]== "TakeDamage")
                //TakeDamage – {hero name} – {damage} – {attacker}
                {
                    int damage = int.Parse(input[2]);
                    int result = healtHave - damage;
                    if (result<=0)
                    {
                        
                        Console.WriteLine($"{heros[ind].Name} has been killed by {input[3]}!");
                        heros.Remove(heros[ind]);
                    }
                    else
                    {
                        heros[ind].Hp = result;
                        Console.WriteLine($"{heros[ind].Name} was hit for {input[2]} " +
                            $"HP by {input[3]} and now has {heros[ind].Hp} HP left!");
                    }
                }
                else if (input[0]== "Recharge")
                //Recharge – {hero name} – {amount}
                {
                    int rech = int.Parse(input[2]);
                    if (manaHave+rech>200&&manaHave<200)
                    {
                        int realRech = rech - ((manaHave + rech) - 200);
                        heros[ind].Mp = 200;
                        Console.WriteLine($"{heros[ind].Name} recharged for {realRech} MP!");
                    }
                    else if (manaHave==200)
                    {
                        Console.WriteLine($"{heros[ind].Name} recharged for 0 MP!");
                    }
                    else
                    {
                        heros[ind].Mp += rech;
                        Console.WriteLine($"{heros[ind].Name} recharged for {rech} MP!");
                    }
                }
                else if (true)
//                    Heal – { hero name} – { amount}

//o   "{hero name} healed for {amount recovered} HP!"

                {
                    int rech = int.Parse(input[2]);
                    if (healtHave + rech > 100 && healtHave < 100)
                    {
                        int realRech = rech - ((healtHave + rech) - 100);
                        heros[ind].Hp = 100;
                        Console.WriteLine($"{heros[ind].Name} healed for {realRech} HP!");
                    }
                    else if (healtHave == 100)
                    {
                        Console.WriteLine($"{heros[ind].Name} healed for 0 HP!");
                    }
                    else
                    {
                        heros[ind].Hp += rech;
                        Console.WriteLine($"{heros[ind].Name} healed for {rech} HP!");
                    }

                }

                input = Console.ReadLine()
                .Split(" - ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }

            foreach (var item in heros.OrderByDescending(x=>x.Hp)
                .ThenBy(x=>x.Name))
            {
                item.Print();
            }
        }
    }
}
