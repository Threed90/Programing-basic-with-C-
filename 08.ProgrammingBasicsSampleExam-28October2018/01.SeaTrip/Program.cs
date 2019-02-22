using System;

namespace _01.SeaTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double food = double.Parse(Console.ReadLine());
            double souvenirs = double.Parse(Console.ReadLine());
            double hotel = double.Parse(Console.ReadLine());

            double travelExpenses = ((420.0 / 100) * 7) * 1.85;

            double FoodAndSouvenirsExpenses = 3 * food + 3 * souvenirs;

            double firstDayHotel = hotel * 0.9;
            double secondDayHotel = hotel * 0.85;
            double thirdDayHotel = hotel * 0.8;

            double total = travelExpenses + FoodAndSouvenirsExpenses + firstDayHotel + secondDayHotel + thirdDayHotel;

            Console.WriteLine($"Money needed: {total:f2}");
        }
    }
}
