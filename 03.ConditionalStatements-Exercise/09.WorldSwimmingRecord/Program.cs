using System;

namespace _09.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordInSeconds = double.Parse(Console.ReadLine());
            double distanceInMeters = double.Parse(Console.ReadLine());
            double SecondsForMeter = double.Parse(Console.ReadLine());

            double totalSec = GetTotalSeconds(distanceInMeters, SecondsForMeter);

            PrintFinalResult(recordInSeconds, totalSec);
        }

        private static void PrintFinalResult(double recordInSeconds, double totalSec)
        {
            if (totalSec < recordInSeconds)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {totalSec:f2} seconds.");
            }
            else if(totalSec >= recordInSeconds)
            {
                Console.WriteLine($"No, he failed! He was {totalSec-recordInSeconds:f2} seconds slower.");
            }
        }

        private static double GetTotalSeconds(double distanceInMeters, double secondsForMeter)
        {
            double totalSec = distanceInMeters * secondsForMeter + ((int)(distanceInMeters / 15) * 12.5);

            return totalSec;
        }
    }
}
