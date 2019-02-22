using System;

namespace AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double BeerLiters = double.Parse(Console.ReadLine());
            double WineLiters = double.Parse(Console.ReadLine());
            double SchnappsLiters = double.Parse(Console.ReadLine());
            double whiskeyLiters = double.Parse(Console.ReadLine());

            double SchnappsPrice = whiskeyPrice / 2;
            double WinePrice = SchnappsPrice - SchnappsPrice * 0.40;
            double beerPrice = SchnappsPrice - SchnappsPrice * 0.80;

            double NeededMoney = whiskeyPrice * whiskeyLiters + beerPrice * BeerLiters + WineLiters * WinePrice + SchnappsPrice * SchnappsLiters;

            Console.WriteLine($"{NeededMoney:f2}");
        }
    }
}
