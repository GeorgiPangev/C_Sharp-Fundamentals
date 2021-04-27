using System;

namespace Nested_Loops___ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int corent = 1;
            bool biger = false;

            for (int rol = 1;  rol<= n; rol ++)
            {
                for (int col = 1; col <= rol; col++)
                {
                    if ( corent> n)
                    {
                        biger = true;
                        break;
                    }
                    Console.Write(corent + " ");
                    corent++;
                }
                Console.WriteLine();
            }
        }
    }
}
