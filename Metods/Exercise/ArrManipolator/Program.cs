using System;
using System.Linq;
using System.Text;

namespace ArrManipolator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] comand = Console.ReadLine()
                .Split()
                .ToArray();
            //string input = inputOne.ToString();
            string inputO = "";
            while (comand[0]!="end")
            {
                
                if (comand[0] == "exchange")
                {
                    input = (string[])Exchange(comand, input);
                     

                    //input.Split("",StringSplitOptions.RemoveEmptyEntries);

                    // .ToString();
                    //Console.WriteLine(String.Join("!",input));
                    //Console.WriteLine(input.Length);
                    

                }
                else if (comand[0] == "max"|| comand[0] == "min")
                {
                    if (comand[1] == "even")
                    {
                        MaxMinEven(input, comand);
                    }
                    else if (comand[1] == "odd")
                    {
                        MaxMinOdd(input, comand);
                    }
                    
                }
                else if (comand[0] == "first"|| comand[0] == "last")
                {
                    if (isInRange(input, comand))
                    {
                        if (comand[0] == "first")
                        {
                            
                                FirstEvenOdd(input, comand);
                            
                        }
                        if (comand[0] == "last")
                        {
                            LastEveOdd(input, comand);
                        }
                    }
                }
                comand = Console.ReadLine()
                    .Split()
                    .ToArray();
            }
        }

        private static void LastEveOdd(string[] input, string[] comand)
        {
            int index = int.Parse(comand[1]);
            StringBuilder str = new StringBuilder();
            int counter = 0;
            bool isFound = false;
            if (comand[2] == "even")
            {
                for (int i = input.Length-1; i >=0 ; i--)
                {
                    if (int.Parse(input[i]) % 2 == 0 && counter <= index)
                    {
                        str.Append(input[i]);
                        counter++;
                        isFound = true;
                    }
                }
            }
            else if (comand[2] == "odd")
            {
                for (int i = input.Length - 1; i >= 0; i--)
                {
                    if (int.Parse(input[i]) % 2 != 0 && counter <= index)
                    {
                        str.Append(input[i]);
                        counter++;
                        isFound = true;
                    }
                }
            }
            string result = str.ToString();
            if (isFound)
            {
                Console.WriteLine($"[{string.Join(", ", result.Reverse())}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }






        private static void FirstEvenOdd(string[] input, string[] comand)
        {
            int index = int.Parse(comand[1]);
            StringBuilder str = new StringBuilder();
            int counter = 0;
            bool isFound = false;
            if (comand[2] == "even")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (int.Parse(input[i]) % 2 == 0 && counter <= index)
                    {
                        str.Append(input[i]);
                        counter++;
                        isFound = true;
                    }
                }
            }
            else if (comand[2] == "odd")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (int.Parse(input[i]) % 2 != 0 && counter <= index)
                    {
                        str.Append(input[i]);
                        counter++;
                        isFound = true;
                    }
                }
            }
            if (isFound)
            {
                Console.WriteLine($"[{string.Join(", ", str.ToString())}]");
            }
            else
            {
                Console.WriteLine("[]");
            }
        }

        private static bool isInRange(string[] input, string[] comand)
        {
            if (int.Parse(comand[1])>= 0 && int.Parse(comand[1])<input.Length)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Invalid count");
                return false;
            }
        }

        private static void MaxMinEven(string[] input, string[] comand)
        {
            int curentValu =int.MinValue;
            
            int curentValumin = int.MaxValue ;
            bool isFound = false;

            if (comand[0]=="max")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int x = int.Parse(input[i].ToString());
                    if (x%2==0&& x>=curentValu)
                    {
                        curentValu = x;
                        isFound = true;
                    }
                }
            }
            else if (comand[0] == "min")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int x = int.Parse(input[i].ToString());
                    if (x % 2 == 0 && x <= curentValumin)
                    {
                        curentValumin = x;
                        isFound = true;
                    }
                }

            }
            if (isFound&& comand[0] == "max")
            {
                Console.WriteLine(curentValu);
            }
            else if (isFound && comand[0] == "min")
            {
                Console.WriteLine(curentValumin);
            }
            else
            {
                Console.WriteLine("No matches");
            }
            return;

        }
        

       

        private static Array Exchange(string[] comand, string[] input)
        {
            string curentStr = "";
            int index = int.Parse(comand[1])+1;
            if (index >= 0&&index<input.Length)
            {
                for (int i = index+1; i < input.Length; i++)
                {
                    curentStr+= (input[i]);
                }
                int x = 0;
                for (int i = 0; i <= index ; i++)
                {
                        curentStr+= (input[i]);
                        x++;
                }
              
            }
            string[] arr = new string[input.Length];
            for (int i = 0; i < curentStr.Length; i++)
            {
                arr[i] = curentStr[i].ToString();
            }
            return arr;
                
        }
        private static void MaxMinOdd(string[] input, string[] comand)
        {
            int curentValu = int.MinValue;

            int curentValumin = int.MaxValue;
            bool isFound = false;

            if (comand[0] == "max")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int x = int.Parse(input[i].ToString());
                    if (x % 2 != 0 && x >= curentValu)
                    {
                        curentValu = x;
                        isFound = true;
                    }
                }
            }
            else if (comand[0] == "min")
            {
                for (int i = 0; i < input.Length; i++)
                {
                    int x = int.Parse(input[i].ToString());
                    if (x % 2 != 0 && x <= curentValumin)
                    {
                        curentValumin = x;
                        isFound = true;
                    }
                }

            }
            if (isFound && comand[0] == "max")
            {
                Console.WriteLine(curentValu);
            }
            else if (isFound && comand[0] == "min")
            {
                Console.WriteLine(curentValumin);
            }
            else
            {
                Console.WriteLine("No matches");
            }
            return;

        }
    }
}
