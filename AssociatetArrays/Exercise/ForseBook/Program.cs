using System;
using System.Collections.Generic;
using System.Linq;

namespace ForseBook
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string, List<string>> forses = new SortedDictionary<string, List<string>>();
            string inputs = Console.ReadLine();
            //.Split('|', "->")
            //.ToArray();
            
            while (inputs!= "Lumpawaroo")
            {
                bool celector = inputs.Contains('|');
                bool isarrol = inputs.Contains('>');

                if (celector)
                {
                    string[] input = inputs
                    .Split(" | ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                    string user = input[1];
                    // bool isUserExist = forses[input[0]].Contains(user);
                    //bool isUserExist = ExistUser(forses, input[0], input[2]);
                    if (ExistUser(forses, input[0], input[1]) == false)
                    {

                    }
                    if (ExistUser(forses, input[0], input[1]) == false)
                    {
                        forses.Add(input[0], new List<string> { input[1] });
                    }
                }



                else if (isarrol)
                
                {
                    string[] input =inputs
                    .Split(" -> ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                   // bool isThear = forses.Contains(input[0]);
                    if (ExistUser(forses, input[1], input[0]))
                    {
                        foreach (var item in forses)
                        {
                            if (item.Value.Contains(input[0]))
                            {
                                item.Value.Remove(input[0]);
                            }
                        }
                        
                        forses[input[1]].Add(input[0]);
                        Console.WriteLine($"{input[0]} joins the {input[1]} side!");
                    }
                    else if (ExistUser(forses, input[1], input[0]) == false)
                    {
                        if (forses.ContainsKey(input[1]))
                        {
                            forses[input[1]].Add(input[0]);
                        }
                        else
                        {


                            forses.Add(input[1], new List<string> {input[0] });
                        }
                        Console.WriteLine($"{input[0]} joins the {input[1]} side!");
                    }
               //     
                   
                }
                inputs = Console.ReadLine();
                
            }

            //SortedDictionary<string, List<string>> orderForses = forses
            //     .OrderByDescending(x => x.Value.Count)
            //     .ThenBy(x => x.Key)
            //     .ToDictionary(c => c.Key, c => c.Value);


            foreach (var f in forses.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                if (f.Value.Count<=0)
                {
                    continue;
                }
                else
                {
                    Console.WriteLine($"Side: {f.Key}, Members: {f.Value.Count}");
                    //List<string> value = (List<string>)f.Value
                    //    .ToList();
                    //value.Sort();

                    foreach (var c in f.Value.OrderBy(x=>x))
                    {
                        Console.WriteLine($"! {c}");
                    }
                    //for (int i = 0; i < value.Count; i++)
                    //{
                      
                    //}

                   // Console.WriteLine($"{string.Join(Environment.NewLine, f.Value.OrderBy(x=>x))}");
                    
                   
                }
                
            }

             static bool ExistUser(SortedDictionary<string, List<string>> forses, string forse, string user )
            {
               // bool contein = false;
                foreach (var f in forses)
                {
                    for (int i = 0; i < f.Value.Count; i++)
                    {
                        if (f.Value[i] == user)
                        {
                            return true;
                        }
                    }
                //    if (f.Value.Contains(user) )
                //    {
                //        contein = true;
                //    }
                }
                return false;
            }
        }

    }
}
