using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderByAge
{
    class Program
    {  
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            List<Order> peoples = new List<Order>();

            while (input[0]!= "End")
            {
                Order newMen = new Order(input[0], int.Parse(input[1]), int.Parse(input[2]));
                peoples.Add(newMen);

                input = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();
            }
           // peoples.OrderBy(x=>x.Age);
            Console.WriteLine(string.Join("",peoples.OrderBy(x => x.Age)));
            


        }

    }
    class Order
    {
        public Order(string name, int number, int age)
        {
            Name = name;
            Number = number;
            Age = age;
        }
        public string  Name { get; set; }
        public int Number { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{Name} with ID: {Number} is {Age} years old.");

            return sb.ToString();
        }
    }
}
