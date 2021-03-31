using System;
using System.Linq;
using System.Text;

namespace _5.Digits_LettersandOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder chars = new StringBuilder();
            StringBuilder digits = new StringBuilder();
            StringBuilder others = new StringBuilder();

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsDigit(text[i]))
                {
                    digits.Append(text[i]);
                }
                else if (char.IsLetter(text[i]))
                {
                    chars.Append(text[i]);
                }
                else
                {
                    others.Append(text[i]);
                }
            }
            Console.WriteLine(digits.ToString());
            Console.WriteLine(chars.ToString());
            Console.WriteLine(others.ToString());

        }
    }
}
