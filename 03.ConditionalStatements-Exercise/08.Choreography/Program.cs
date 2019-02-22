using System;

namespace _08.Choreography
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSteps = int.Parse(Console.ReadLine());
            int numberOfDancers = int.Parse(Console.ReadLine());
            int daysForLearning = int.Parse(Console.ReadLine());

            double dailyStep = GetPercentOfStepPerDancer(numberOfSteps,numberOfDancers, daysForLearning);

            if (GetTotalStepsPerDay(numberOfSteps, daysForLearning) <= 13)
            {
                Console.WriteLine($"Yes, they will succeed in that goal! {dailyStep:f2}%.");
            }
            else
            {
                Console.WriteLine($"No, They will not succeed in that goal! Required {dailyStep:f2}% steps to be learned per day.");
            }
        }

        private static double GetPercentOfStepPerDancer(int numberOfSteps,int dancers, int daysForLearning)
        {
            double stepPerDay = GetTotalStepsPerDay(numberOfSteps, daysForLearning);

            double dancersStepPerDay = stepPerDay / dancers;

            return dancersStepPerDay;
        }

        private static double GetTotalStepsPerDay(int steps, int days)
        {
            double stepPerDay = Math.Ceiling((((double)steps / days) / steps)*100);

            return stepPerDay;
        }
    }
}
