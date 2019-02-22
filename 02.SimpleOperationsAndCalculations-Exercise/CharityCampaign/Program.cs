using System;

namespace CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakes = int.Parse(Console.ReadLine());
            int waffles = int.Parse(Console.ReadLine());
            int pancakes = int.Parse(Console.ReadLine());

            double SellsForaDay = (cakes * 45.00 + waffles * 5.80 + pancakes * 3.20)*confectioners;

            double totalSells = SellsForaDay * days;

            double profitFromCampaign = totalSells - (totalSells / 8);

            Console.WriteLine($"{profitFromCampaign:f2}");

        }
    }
}
