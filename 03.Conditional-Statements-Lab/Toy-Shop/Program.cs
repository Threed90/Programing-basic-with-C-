using System;

namespace Toy_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Цена на екскурзията -реално число в интервала[1.00 … 10000.00]
            //Брой пъзели - цяло число в интервала[0… 1000]
            //Брой говорещи кукли -цяло число в интервала[0 … 1000]
            //Брой плюшени мечета -цяло число в интервала[0 … 1000]
            //Брой миньони - цяло число в интервала[0 … 1000]
            //Брой камиончета - цяло число в интервала[0 … 1000]
            double excursionPrice = double.Parse(Console.ReadLine());
            int numberOfPuzzles = int.Parse(Console.ReadLine());
            int numberOfDolls = int.Parse(Console.ReadLine());
            int numberOfTeddyBears = int.Parse(Console.ReadLine());
            int numberOfMinions = int.Parse(Console.ReadLine());
            int numberOfTruckToys = int.Parse(Console.ReadLine());

            double leftedMoneys = GetTotalRevenues(numberOfPuzzles, numberOfDolls, numberOfTeddyBears, numberOfMinions, numberOfTruckToys);

            bool isEnough = (leftedMoneys >= excursionPrice);

            if (isEnough)
            {
                Console.WriteLine($"Yes! {leftedMoneys-excursionPrice:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice-leftedMoneys:f2} lv needed.");
            }

        }

        
        /// <summary>
        /// Calculate revenues - discount - rent for shop and give back lefted profit.
        /// </summary>
        /// <param name="puzzles"></param>
        /// <param name="dolls"></param>
        /// <param name="teddyBears"></param>
        /// <param name="minions"></param>
        /// <param name="truckToys"></param>
        /// <returns></returns>
        private static double GetTotalRevenues(int puzzles, int dolls, int teddyBears, int minions, int truckToys)
        {
            double totalRevenues = puzzles * 2.60 + dolls * 3.00 + teddyBears * 4.10 + minions * 8.20 + truckToys * 2.00;

            if ((puzzles + dolls + teddyBears + minions + truckToys) >= 50)
            {
                totalRevenues -= (totalRevenues * 0.25);
            }

            totalRevenues -= (totalRevenues * 0.10);

            return totalRevenues;
        }
    }
}
