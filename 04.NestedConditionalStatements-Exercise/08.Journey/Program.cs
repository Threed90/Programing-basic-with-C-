using System;

namespace _08.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            

            PrintVacantionOportunities(budget, season);
        }

        private static void PrintVacantionOportunities(double budget, string season)
        {
            string destination = "";
            string place = "";
            double price = 0;

            if (budget <= 100)
            {
                destination = "Bulgaria";
                if (season == "summer")
                {
                    place = "Camp";
                    price = budget * 0.30;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    price = budget * 0.70;
                }
            }
            else if (budget <= 1000)
            {
                destination = "Balkans";
                if (season == "summer")
                {
                    place = "Camp";
                    price = budget * 0.40;
                }
                else if (season == "winter")
                {
                    place = "Hotel";
                    price = budget * 0.80;
                }
            }
            else if (budget > 1000)
            {
                destination = "Europe";
                place = "Hotel";
                price = budget * 0.90;
            }

            Console.WriteLine($"Somewhere in {destination}{Environment.NewLine}{place} - {price:f2}");
        }
    }
}
