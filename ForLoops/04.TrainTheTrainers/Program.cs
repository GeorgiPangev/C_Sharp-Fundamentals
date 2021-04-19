using System;

namespace _04.TrainTheTrainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double corentSum = 0;
            double allSum = 0;
            double counterPres = 0;
            bool isFinish = false;

            while (!isFinish)
            {
                string pres = Console.ReadLine();
                if (pres == "Finish" )
                {
                    break;
                }
                for (int i = 1; i <= n; i++)
                {
                    string input = Console.ReadLine();
                    if (input == "Finish")
                    {
                        isFinish = true; break;
                    }
                    double greid = double.Parse(input);
                    counterPres++;
                    corentSum += greid;
                    allSum += greid;
                }
                Console.WriteLine($"{pres} - {(corentSum/ n):F2}.");
                corentSum = 0;
            }
            Console.WriteLine($"Student's final assessment is {(allSum/ counterPres):F2}.");

        }
    }
}
