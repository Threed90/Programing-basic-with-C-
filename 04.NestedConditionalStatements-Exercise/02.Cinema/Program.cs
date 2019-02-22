using System;
using System.Linq;

namespace _02.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string projection = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            PrintTotal(projection, row, column);
        }

        private static void PrintTotal(string projection, int row, int column)
        {
            string[] projectionType = { "Premiere", "Normal", "Discount" };
            double[] ticketPrice = { 12.00, 7.50, 5.00 };

            int index = Array.IndexOf(projectionType, projection);

            double total = ticketPrice[index] * (row * column);

            Console.WriteLine($"{total:f2} leva");
        }
    }
}
