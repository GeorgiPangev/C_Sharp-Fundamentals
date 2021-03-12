using System;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int numb = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numb; i++)
            {
                FirstLine(i);
            }
            for (int i = numb-1; i >= 1; i--)
            {
                FirstLine(i);
            }
            
           
        }
        static void FirstLine(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.Write(i+ " ");
            }
            Console.WriteLine();
        }
       
        
    }
}
