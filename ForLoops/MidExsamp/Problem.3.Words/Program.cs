using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem._3.Words
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            while (command[0]!= "Stop")
            {
                if (command[0] == "Delete")
                {
                    // bool isIn = IsIn(command[1], words.Count);
                    if (int.Parse(command[1])>=0&&
                        int.Parse(command[1])+1<words.Count)
                    {
                        words.RemoveAt(int.Parse(command[1]) + 1);
                    }
                }
                else if (command[0] == "Swap")
                {

                    int first = words.IndexOf(command[1]);
                    int second = words.IndexOf(command[2]);
                    if (words.Contains(command[1]) && words.Contains(command[2]))

                    {
                        string firststr = words[first];
                        string secondstr = words[second];
                        words[first] = secondstr;
                        words[second] = firststr;
                    }

                }
                else if (command[0].ToLower() == "put")
                {

                    if (int.Parse(command[2]) < words.Count && int.Parse(command[2]) > 0)
                    {
                        // int ind = int.Parse(command[2]);
                        if (int.Parse(command[2]) < words.Count - 1
                            && int.Parse(command[2]) >= 1)
                        {
                            words.Insert(int.Parse(command[2]) - 1, command[1]);

                        }

                        else if (int.Parse(command[2]) == words.Count - 1)
                        {
                            words.Insert(int.Parse(command[2]), command[1]);
                            //words.Add(command[1]);
                        }
                    }
                    else if (words.Count == 1 && int.Parse(command[2]) == 0)
                    {
                        words.Add(command[1]);
                    }
                }

                else if (command[0] == "Sort")
                {
                    words.Sort();
                    words.Reverse();
                }
                else if (command[0] == "Replace")
                {
                    string oldstr = command[2];
                    string newstr = command[1];
                    if (words.Contains(oldstr))
                    {
                        int ind = words.IndexOf(oldstr);
                        words[ind] = newstr;
                    }
                }
                    
                

                command = Console.ReadLine()
                .Split();
            }
            Console.WriteLine(string.Join(" ", words));

        }

        private static bool IsIn(int p, int count)
        {
            int check = p;
            if ( check >= 0 && check<count)
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
