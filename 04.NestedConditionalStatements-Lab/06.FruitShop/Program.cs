using System;
using System.Linq;

namespace _06.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());

            PrintPrice(fruit, day, quantity);
        }

        private static void PrintPrice(string fruit, string day, double quantity)
        {
            string[] fruits = { "banana", "apple", "orange", "grapefruit", "kiwi", "pineapple", "grapes" };

            string[] workingDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };
            string[] weekEnd = { "Saturday", "Sunday" };

            double[] prices = new double[fruits.Length];

            if (workingDays.Contains(day))
            {
                prices = new double[] { 2.50, 1.20, 0.85, 1.45, 2.70, 5.50, 3.85 };
            }
            else if (weekEnd.Contains(day))
            {
                prices = new double[] { 2.70, 1.25, 0.90, 1.60, 3.00, 5.60, 4.20 };
            }

            if((!fruits.Contains(fruit)) || !(workingDays.Contains(day)|| weekEnd.Contains(day)))
            {
                Console.WriteLine("error");
            }
            else
            {
                int index = Array.IndexOf(fruits, fruit);

                Console.WriteLine($"{quantity*prices[index]:f2}");
            }
        }
    }
}
