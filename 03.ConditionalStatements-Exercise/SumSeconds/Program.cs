using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int seconds = int.Parse(Console.ReadLine());
            int seconds2 = int.Parse(Console.ReadLine());
            int seconds3 = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMinutes(seconds,seconds2,seconds3));
        }

        private static string GetMinutes(int sec, int sec2, int sec3)
        {
            int totalSeconds = sec + sec2 + sec3;

            string secondsInMinutes = $"{totalSeconds / 60}:{totalSeconds % 60:d2}";

            return secondsInMinutes;
        }
    }
}
