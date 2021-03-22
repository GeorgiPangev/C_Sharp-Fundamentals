using System;

namespace SmalestOfTreeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int tree = int.Parse(Console.ReadLine());

            LowestNumb(one,two, tree);
        }

        private static void LowestNumb(int one, int two, int tree)
        {
            int LolNumberOneTwo = Math.Min(one, two);
            int LolestNumb = Math.Min(LolNumberOneTwo, tree);
            Console.WriteLine(LolestNumb);
            //return LolestNumb;
        }
    }
}
