using System;

namespace Problem._1.TankBattleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            double nededExp = double.Parse(Console.ReadLine());
            double battlesToPlay = int.Parse(Console.ReadLine());
            double exp = 0.0;
            int battlesCounter = 0;
            bool isDone = false;
            for (int i = 0; i < battlesToPlay; i++)
            {
                battlesCounter++;
                double gainedExp = double.Parse(Console.ReadLine());
                double bonus = 0.0;

                if (battlesCounter%3== 0)
                {
                    bonus += (gainedExp * 0.15);
                }
                else if (battlesCounter%5==0)
                {
                    bonus -= (gainedExp * 0.1);

                }
                else if (battlesCounter%15 == 0)
                {
                    bonus += (gainedExp * 0.05);
                }
                gainedExp = CalcExp(gainedExp, bonus);
                exp += gainedExp;
                

                if (exp>= nededExp)
                {
                    isDone = true;
                    break;
                }
            }
            if (isDone)
            {
                Console.WriteLine($"Player successfully collected his needed experience for {battlesCounter} battles.") ;
            }
            else
            {
                Console.WriteLine($"Player was not able to collect the needed experience, {(nededExp-exp):F2} more needed.");
            }
        }

        private static double CalcExp(double gainedExp, double bonus)
        {
            if (bonus >0)
            {
                gainedExp += bonus;
            }
            else
            {
                gainedExp = gainedExp + bonus;
            }
            return gainedExp;
        }
    }
}
