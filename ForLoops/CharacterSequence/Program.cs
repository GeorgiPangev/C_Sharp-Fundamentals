using System;

namespace CharacterSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            String inp = Console.ReadLine();

            for (int i = inp.Length-1; i >=0 ; i--)
            {
                char lethr = inp[i];
                Console.WriteLine(lethr);
            }
        }
    }
}
