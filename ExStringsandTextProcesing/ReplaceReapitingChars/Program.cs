using System;


namespace ReplaceReapitingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            // StringBuilder result = new StringBuilder();
            string result = input;
            for (int i = 0; i < result.Length - 1; i++)
            {
                if (result[i] == result[i + 1])
                {
                    result = result.Remove(result[i], 1);
                    i++;
                }
            }
            //result.Append(input[input.Length - 1]);


            Console.WriteLine(result);





        }
    }
}
