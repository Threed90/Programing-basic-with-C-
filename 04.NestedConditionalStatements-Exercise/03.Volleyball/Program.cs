using System;

namespace _03.Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            string yearType = Console.ReadLine();
            int holydays = int.Parse(Console.ReadLine());
            int homeTown = int.Parse(Console.ReadLine());

            double inSofia = GetDaysInSofia(holydays, homeTown);

            double total = GetTotalDayForVolleyball(yearType, homeTown, inSofia);

            Console.WriteLine(total);
        }

        private static double GetTotalDayForVolleyball(string yearType, int homeTown, double inSofia)
        {
            double total = inSofia + homeTown;

            if (yearType == "leap")
            {
                total += total * 0.15;
            }

            

            return Math.Floor(total);
        }

        private static double GetDaysInSofia( int holydays, int homeTown)
        {
            double inSofia = ((48 - homeTown) * 3.0 / 4) + (holydays*2.0/3);

            return inSofia;
        }
    }
}
