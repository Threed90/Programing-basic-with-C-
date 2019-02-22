using System;

namespace _02.SmallShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine().ToLower();
            string city = Console.ReadLine().ToLower();
            double quntity = double.Parse(Console.ReadLine());

            double result = GetResult(product, city, quntity);

            Console.WriteLine(result);
        }

        private static double GetResult(string product, string city, double quantity)
        {
            string[] productName = new string[5] { "coffee", "water", "beer", "sweets", "peanuts" };

            double[] prices = new double[5];

            if (city == "sofia")
            {
                prices = new double[] { 0.50, 0.80, 1.20, 1.45, 1.60 };
            }
            else if (city == "plovdiv")
            {
                prices = new double[] { 0.40, 0.70, 1.15, 1.30, 1.50 };
            }
            else if (city == "varna")
            {
                prices = new double[] { 0.45, 0.70, 1.10, 1.35, 1.55 };
            }

            int index = Array.IndexOf(productName, product);

            double bill = quantity * prices[index];

            return bill;
        }
    }
}
