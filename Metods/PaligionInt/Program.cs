using System;
using System.Linq;
using System.Text;


namespace PaligionInt
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input !="END")
            {

         
            int[] arr = (int[])ConvertToArray(input);

                if (IsOrNot(arr))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            ;
            input = Console.ReadLine();

            }



        }

        private static bool IsOrNot(int[] arr)
        {
            bool IsDifrent = false;
            
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i]!=arr[(arr.Length-1)-i])
                {
                    IsDifrent = true;
                }
            }
            if (IsDifrent)
            {
                return false;

            }
            else
            {
                return true;
            }
        }

        private static Array ConvertToArray(string input)
        {
            int[] array = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                array[i] = int.Parse(input[i].ToString());

            }
            return array;
        }
    }
}
