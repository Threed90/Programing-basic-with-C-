using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int points = int.Parse(Console.ReadLine());

            double totalPoints = points + GetBonus(points);
            Console.WriteLine(GetBonus(points));
            Console.WriteLine(totalPoints);
        }

        private static double GetBonus(int points)
        {
            double bonusPoints = 0;
            if (points <= 100)
            {
                bonusPoints = 5;
            }
            else if (points > 1000)
            {
                bonusPoints = (points * 0.10);
            }
            else if (points > 100)
            {
                bonusPoints += (points * 0.20);
            }

            if (points % 2 == 0)
            {
                bonusPoints++;
            }
            else if (points % 10 == 5)
            {
                bonusPoints += 2;
            }
            return bonusPoints;

        }
    }
}
