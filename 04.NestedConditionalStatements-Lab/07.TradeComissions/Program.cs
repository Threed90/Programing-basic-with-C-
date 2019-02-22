using System;
using System.Linq;

namespace _07.TradeComissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine().ToLower();
            double sells = double.Parse(Console.ReadLine());

            PrintCommision(city, sells);
        }

        private static void PrintCommision(string city, double sells)
        {
            double[] commision = { };

            bool[] isCommisionRange = new bool[] { 0 <= sells && sells <= 500, 500 < sells && sells <= 1000, 1000 < sells && sells <= 10000, sells > 10000 };

            if (city == "sofia")
            {
                commision = new double[] { 0.05, 0.07, 0.08, 0.12 };
            }
            else if( city== "varna")
            {
                commision = new double[] { 0.045, 0.075, 0.10, 0.13 };
            }
            else if (city == "plovdiv")
            {
                commision = new double[] { 0.055, 0.08, 0.12, 0.145 };
            }
            else
            {
                Console.WriteLine("error");
                return;
            }

            if (isCommisionRange.Contains(true))
            {
                int index = Array.IndexOf(isCommisionRange, true);

                Console.WriteLine($"{sells*commision[index]:f2}");
            }
            else
            {
                Console.WriteLine("error");
                return;
            }
        }
    }
}
