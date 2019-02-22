using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int numberOfFlowers = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double price = GetPrice(flowers, numberOfFlowers);

            double discountPrice = GetDiscount(numberOfFlowers, price, flowers);

            if (budget < discountPrice)
            {
                Console.WriteLine($"Not enough money, you need {discountPrice-budget:f2} leva more.");
            }
            else
            {
                Console.WriteLine($"Hey, you have a great garden with {numberOfFlowers} {flowers} and {budget-discountPrice:f2} leva left.");
            }
        }

        private static double GetDiscount(int numberOfFlowers, double price, string flowers)
        {
            string[] allFlowers = { "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus" };
            if (flowers == allFlowers[0] && numberOfFlowers > 80)
            {
                price -= price * 0.10;

            }
            else if(flowers == allFlowers[1] && numberOfFlowers > 90)
            {
                price -= price * 0.15;
            }
            else if(flowers == allFlowers[2] && numberOfFlowers > 80)
            {
                price -= price * 0.15;
            }
            else if (flowers == allFlowers[3] && numberOfFlowers < 120)
            {
                price += price * 0.15;
            }
            else if(flowers == allFlowers[4] && numberOfFlowers < 80)
            {
                price += price * 0.20;
            }

            return price;
        }

        private static double GetPrice(string flowers, int numberOfFlowers)
        {
            string[]  allFlowers = { "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"};
            double[] prices = { 5.00, 3.80, 2.80, 3.00, 2.50 };

            int index = Array.IndexOf(allFlowers, flowers);

            double price = numberOfFlowers * prices[index];

            return price;
        }
    }
}
