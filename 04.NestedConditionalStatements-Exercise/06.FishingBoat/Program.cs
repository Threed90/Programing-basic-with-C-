using System;

namespace _06.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermans = int.Parse(Console.ReadLine());
            

            double price = GetPrice(season, fishermans);

            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {(double)budget - price:f2} leva left.");
            }
            else if (price > budget)
            {
                Console.WriteLine($"Not enough money! You need {price-budget:f2} leva.");
            }

            
        }
        static double GetPrice(string season, int fishermans)
        {
            double price =0;

            if (season == "Spring")
            {
                price = 3000;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                price = 4200;
            }
            else if (season == "Winter")
            {
                price = 2600;
            }

            if (fishermans <= 6)
            {
                price -= price * 0.10;
            }
            else if (fishermans > 6 && fishermans <= 11)
            {
                price -= price * 0.15;
            }
            else if (fishermans > 11)
            {
                price -= price * 0.25;
            }

            if (season != "Autumn" && fishermans % 2 == 0)
            {
                price -= price * 0.05;
            }

            return price;
        }
    }
}
