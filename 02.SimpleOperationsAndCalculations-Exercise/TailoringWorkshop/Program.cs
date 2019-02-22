using System;

namespace TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int tables = int.Parse(Console.ReadLine());
            double lengthTable = double.Parse(Console.ReadLine());
            double widthTable = double.Parse(Console.ReadLine());

            double CoverArea = (lengthTable+2*0.3) * (widthTable+2*0.3);
            double SquareArea = (lengthTable / 2) * (lengthTable / 2);

            double totalPriceUSD = (CoverArea * 7 + SquareArea * 9) * tables;
            double totalPriceBGN = totalPriceUSD * 1.85;

            Console.WriteLine($"{totalPriceUSD:f2} USD");
            Console.WriteLine($"{totalPriceBGN:f2} BGN");
        }
    }
}
