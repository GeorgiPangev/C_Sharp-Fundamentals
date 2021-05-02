using System;
using System.Collections.Generic;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<int>> users = new Dictionary<string, List<int>>();
            // List[0] = likes, list[1]= coments
            string input = Console.ReadLine();
            while (input!= "Log out")
            {
                string[] comand = input.Split(": ", StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string com = comand[0];
                string name = comand[1];

                if (com == "New follower")
                {
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, new List<int>());
                        users[name].Add(0);
                        users[name].Add(0);

                    }
                }
                else if (com == "Like")
                {
                    int num = int.Parse(comand[2]);
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, new List<int>());
                        users[name].Add(num);
                        users[name].Add(0);
                    }
                    else
                    {
                        users[name][0] += num;
                    }
                }
                else if (com == "Comment")
                {
                    if (!users.ContainsKey(name))
                    {
                        users.Add(name, new List<int>());

                        //users[name][1] += 1;
                         users[name].Add(0);
                         users[name].Add(1);
                        int x = users[name][1];
                        //Console.WriteLine(x);
                    }
                    else
                    {
                        users[name][1] += 1;
                    }
                }
                else if (com == "Blocked")
                {
                    if (users.ContainsKey(name))
                    {
                        users.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} doesn't exist.");
                    }
                }
                input = Console.ReadLine();
            }

            Console.WriteLine($"{users.Count} followers");
            if (users.Count > 0)
            {
                foreach (var item in users.OrderByDescending(x=>x.Value.Sum()).ThenBy(x=>x.Key))
                {
                    int x = item.Value.Sum();
                    Console.WriteLine($"{item.Key}: {x}");
           
                }
            }
        }
    }
}
