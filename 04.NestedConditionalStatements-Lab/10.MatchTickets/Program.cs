using System;

namespace _10.MatchTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int numberOfPeople = int.Parse(Console.ReadLine());

            PrintResult(budget, ticketCategory, numberOfPeople);
        }

        private static void PrintResult(double budget, string ticketCategory, int people)
        {
            bool[] isPeopleNumber = new bool[] { 1 <= people && people <= 4, 5 <= people && people <= 9, 10 <= people && people <= 24, 25 <= people && people <= 49, 50 <= people };
            double[] percent = new double[] { 0.75, 0.60, 0.50, 0.40, 0.25 };

            double lefted = budget - budget * percent[Array.IndexOf(isPeopleNumber, true)];

            double ticketPrice = 0;

            if(ticketCategory == "VIP")
            {
                ticketPrice = people * 499.99;
            }
            else if(ticketCategory == "Normal")
            {
                ticketPrice = people * 249.99;
            }

            if (ticketPrice <= lefted)
            {
                Console.WriteLine($"Yes! You have {lefted-ticketPrice:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {ticketPrice-lefted:f2} leva.");
            }
        }
    }
}
