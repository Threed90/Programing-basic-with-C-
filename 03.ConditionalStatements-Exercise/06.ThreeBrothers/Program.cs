using System;

namespace _06.ThreeBrothers
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstBrotherTime = double.Parse(Console.ReadLine());
            double secondBrotherTime = double.Parse(Console.ReadLine());
            double thirdBrotherTime = double.Parse(Console.ReadLine());
            double fathersFishingTime = double.Parse(Console.ReadLine());

            double cleaningTime = GetTogetherCleaningTime(firstBrotherTime, secondBrotherTime, thirdBrotherTime);

            Console.WriteLine(GetResult(cleaningTime, fathersFishingTime));
        }

        private static string GetResult(double cleaningTime, double fathersFishingTime)
        {
            string result = "";

            if (cleaningTime <= fathersFishingTime)
            {
                result = $"Cleaning time: {cleaningTime:f2}{Environment.NewLine}" +
                         $"Yes, there is a surprise - time left -> {Math.Floor(fathersFishingTime-cleaningTime)} hours.";
            }
            else
            {
                result = $"Cleaning time: {cleaningTime:f2}{Environment.NewLine}" +
                    $"No, there isn't a surprise - shortage of time -> {Math.Ceiling(cleaningTime - fathersFishingTime)} hours.";
            }
            return result;
        }

        private static double GetTogetherCleaningTime(double firstBrotherTime, double secondBrotherTime, double thirdBrotherTime)
        {
            double cleaningTime = 1 / (1 / firstBrotherTime + 1 / secondBrotherTime + 1 / thirdBrotherTime);

            cleaningTime += (cleaningTime * 0.15);

            return cleaningTime;
        }
    }
}
