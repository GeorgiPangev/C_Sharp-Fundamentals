using System;
using System.Text;

namespace GreaterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();

            Console.WriteLine(PrintMaks(type, x, y));

        }

        private static string PrintMaks(string type, string x, string y)
        {
            string toBeReturned = string.Empty;
            switch (type)
            {

                case "int":
                    int z = (int)Math.Max(int.Parse(x), (int.Parse)(y));
                    toBeReturned=z.ToString();
                    break;

                case "char":
                case "string":
                    int comp = String.Compare(x, y);
                    if (comp<0)
                    {
                        toBeReturned= y;
                       
                    }
                    else
                    {
                        toBeReturned= x;
                    }

                    break;

               
            }
            return toBeReturned;

        }
    }


        //static string PrintMaks(string input,string x, string y) 
        //{
        //    switch
        //    x = int.Parse(Console.ReadLine());
        //    y = int.Parse(Console.ReadLine());


        //    return Math.Max(x, y);

        //}
        
        //static char PrintMaks(char charOne, char charTwo)
        //{
        //    charOne = Char.Parse(Console.ReadLine());
        //    charTwo = Char.Parse(Console.ReadLine());

        //    char z = (char)Math.Max((int)charOne, (int)charTwo);
        //    return z;
        //}
      
        //static string PrintMaks(string strOne, String strTwo)
        //{
        //   // StringBuilder maxStr = new StringBuilder();

        //    strOne = Console.ReadLine();
        //    strTwo = Console.ReadLine();
        //    int max = String.Compare(strOne, strTwo);
        //    if (max<0)
        //    {
        //        return strOne;
        //    }
        //    else
        //    {
        //        return strTwo;

        //    }







    
}
