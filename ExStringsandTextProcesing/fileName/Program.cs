using System;

namespace fileName
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(@"\");
            var names = input[input.Length - 1].Split('.');
            string name = names[0];
            string type = names[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {type}");
        }
    }
}
