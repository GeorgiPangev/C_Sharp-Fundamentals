using System;

namespace _5.PassGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                for (int o = 1; o < n ; o++)
                {
                    for (int p = 'a'; p < 'a'+ l ; p++)
                    {
                        for (int q = 'a'; q <  'a'+l; q++)
                        {
                            for (int w = 2; w <=n ; w++)
                            {
                                if (i<w && o<w)
                               {
                                   
                                    Console.Write($"{i}{o}{(char)p}{(char)q}{w} ");
                               }
                              //  else if (i>= w&&o>= w )
                               // {
                                  //  Console.Write($"{i}{0}{(char)p}{(char)q}{w++} ");
                               // }
                                
                            }
                           
                        }
                    }
                }
            }
            

        }
    }
}
