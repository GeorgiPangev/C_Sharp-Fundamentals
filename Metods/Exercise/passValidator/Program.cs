using System;

namespace passValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine()
                .ToLower();
            bool islenghtRigt = LenghtCheck(input);
            bool IsLetersAndDigitsOnli = LethrsDigCheck(input);
            bool IsTwoDigitIn = DigitCheck(input);

            if (!islenghtRigt)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!IsLetersAndDigitsOnli)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!IsTwoDigitIn)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (islenghtRigt&& IsLetersAndDigitsOnli&& IsTwoDigitIn)
            {
                Console.WriteLine("Password is valid");
            }

        }

        private static bool DigitCheck(string input)
        {
            int sumOfDigit = 0;
            foreach (var item in input)
            {
                if (char.IsDigit(item))
                {
                    sumOfDigit++;
                }
            }
            if (sumOfDigit>=2)
            {
                return true;

            }
            else
            {
                return false;
            }
        }

        private static bool LethrsDigCheck(string input)
        {
            bool isNotinRange = true;
            for (int i = 0; i < input.Length; i++)
            {
                if (!char.IsLetterOrDigit(input[i]))
                {
                    isNotinRange = false;
                }
               
                
            }
            return isNotinRange;
        }

        private static bool LenghtCheck(string input)
        {
            if (input.Length>=6&& input.Length<=10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
