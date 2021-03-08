using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem._2.Coffe
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffes = Console.ReadLine()
                .Split()
                .ToList();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] comand = Console.ReadLine().Split();
                if (comand[0]== "Include")
                {
                    coffes.Add(comand[1]);
                }
                else if (comand[0]== "Remove"&& coffes.Count >= int.Parse(comand[2]))
                {
                   
                        coffes = ToRemove(coffes, comand);
                    
                }
                else if (comand[0]== "Prefer")
                {
                    int first = int.Parse(comand[1]);
                    int second = int.Parse(comand[2]);
                    if ((first>=0&&first<coffes.Count)
                        && (second >= 0 && second < coffes.Count))
                    {
                        string firststr = coffes[first];
                        string secondstr = coffes[second];
                        coffes[first] = secondstr;
                        coffes[second] = firststr;
                    }
                }
                else if (comand[0]== "Reverse")
                {
                    coffes.Reverse();
                }
               
            }
            Console.WriteLine("Coffees:");
            Console.WriteLine(string.Join(" ", coffes));

        }

        private static List<string> ToRemove(List<string> coffes, string[] comand)
        {
           
                for (int i = 0; i < int.Parse(comand[2]); i++)

                {

                    if (comand[1] == "first"&&coffes.Count>=1)
                    {
                    coffes.RemoveAt(0);
                    }
                    else if (comand[1] == "last" && coffes.Count > 1)
                
                    {
                    coffes.RemoveAt(coffes.Count - 1);

                    }
                }
            return coffes;
           
        }
    }
}
