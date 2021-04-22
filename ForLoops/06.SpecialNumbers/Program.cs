using System;

namespace _06.SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isMajick0 = false;
            bool isMajick1 = false;
            bool isMajick2 = false;
            bool isMajick3 = false;

            int current = 0;

            for (int i = 1111; i <= 9999; i++)
            {
                string cNumStr = i.ToString();
                for (int j = 0; j < cNumStr.Length; j++)
                {
                    int digit = int.Parse(cNumStr[j].ToString());
                    if (j == 0 && digit != 0 && n % digit == 0)
                    { isMajick0 = true;  }
                    if (j == 1 && digit != 0 && n % digit == 0)
                    { isMajick1 = true; }
                    if (j == 2 && digit != 0 && n % digit == 0)
                    { isMajick2 = true; }
                    if (j == 3 &&  digit != 0 &&  n % digit == 0   )
                    { isMajick3 = true; }
                }
                if (isMajick0 && isMajick1 && isMajick2 && isMajick3)
                {
                    Console.Write(i + " ");
                    
                }
                isMajick0 = false;
                isMajick1 = false;
                isMajick2 = false;
                isMajick3 = false;



            }
        }
    }
}
