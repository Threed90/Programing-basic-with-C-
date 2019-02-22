using System;
using System.Linq;

namespace _09.Fishing
{
    class Program
    {
        static void Main(string[] args)
        {

            int quota = int.Parse(Console.ReadLine());

            double total = 0;
            int counter = 0;
            GetTotalAndNumberOfFishes(quota, ref total, ref counter);

            PrintResult(quota, total, counter);
        }

        private static void GetTotalAndNumberOfFishes(int quota, ref double total, ref int counter)
        {
            for (int i = 1; i <= quota; i++)
            {
                string fishName = Console.ReadLine();
                if (fishName == "Stop")
                {
                    break;
                }
                double fishKilos = double.Parse(Console.ReadLine());

                if (i % 3 == 0)
                {
                    total += (fishName.ToCharArray().Select(x => (double)x).Sum() / fishKilos);
                }
                else
                {
                    total -= (fishName.ToCharArray().Select(x => (double)x).Sum() / fishKilos);
                }
                counter++;
            }
        }

        private static void PrintResult(int quota, double total, int counter)
        {
            if (quota == counter)
            {
                Console.WriteLine("Lyubo fulfilled the quota!");
            }

            if (total < 0)
            {
                Console.WriteLine($"Lyubo lost {Math.Abs(total):f2} leva today.");
            }
            else
            {
                Console.WriteLine($"Lyubo's profit from {counter} fishes is {total:f2} leva.");
            }
        }
    }
}
