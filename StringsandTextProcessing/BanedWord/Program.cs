using System;
using System.Linq;
using System.Text;

namespace BanedWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] baned = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string text = Console.ReadLine();
            //StringBuilder text = new StringBuilder(textOne.Length);
            //text.Append(textOne);

            foreach (var word in baned)
            {
                while (text.Contains(word))
                {
                    string n = new string('*', word.Length);
                    text = text.Replace(word, new string('*', word.Length));
                }
            }
            Console.WriteLine(text);
        }
    }
}
