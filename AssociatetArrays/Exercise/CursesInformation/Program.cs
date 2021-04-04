using System;

using System.Collections.Generic;
using System.Linq;

namespace CursesInformation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> curses = new Dictionary<string, List<string>>();

            string[] input = Console.ReadLine()
                 .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

            while (input[0]!= "end")
            {
                string curentCurs = input[0];
                string curentStudent = input[1];
                if (curses.ContainsKey(curentCurs)== false)
                {
                    curses.Add(curentCurs, new List<string> { curentStudent });
                }
                else if (curses.ContainsKey(curentCurs))
                {
                    if (curses[curentCurs].Contains(curentStudent) == false)
                    {
                        curses[curentCurs].Add(curentStudent);
                    }
                }
                input = Console.ReadLine()
                 .Split(" : ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            }
            
            foreach (var curs in curses.OrderByDescending(x=>x.Value.Count))
            {
                Console.WriteLine($"{curs.Key}: {curs.Value.Count}");
                // foreach (var student in curs.Value.OrderBy(x=>x))
                //
                
                    Console.WriteLine($"{string.Join(Environment.NewLine,curs.Value)}");
                //}

            }



        }
    }
}
