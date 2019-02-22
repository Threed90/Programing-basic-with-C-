using System;

namespace _06.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int iterations = int.Parse(Console.ReadLine());

            int counter = 0;

            double total = 0;

            while (counter<iterations)
            {
                double amount = double.Parse(Console.ReadLine());

                if (amount < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                Console.WriteLine($"Increase: {amount:f2}");

                total += amount;

                counter++;
            }

            Console.WriteLine($"Total: {total:f2}");
        }
    }
}
