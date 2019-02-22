using System;

namespace _10.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());


            double studioPrice = GetStudioPrice(month, nights);
            double apartmentPrice = GetApartmentPrice(month, nights);


            Console.WriteLine($"Apartment: {apartmentPrice:f2} lv.");
            Console.WriteLine($"Studio: {studioPrice:f2} lv.");
        }

        private static double GetApartmentPrice(string month, int nights)
        {
            double price = 0;

            if (month == "May" || month == "October")
            {
                price = 65.00 * nights;
            }
            else if (month == "June" || month == "September")
            {
                price = 68.70 * nights;
            }
            else if (month == "July" || month == "August")
            {
                price = nights * 77.00;
            }
            if (nights > 14)
            {
                price -= price * 0.10;
            }

            return price;
        }

        private static double GetStudioPrice(string month, int nights)
        {
            double price = 0;

            if (month == "May" || month == "October")
            {
                price = 50.00 * nights;

                if (nights > 14)
                {
                    price -= price * 0.30;
                }
                else if (nights > 7)
                {
                    price -= price * 0.05;
                }

            }
            else if (month == "June" || month == "September")
            {
                price = 75.20 * nights;

                if (nights > 14)
                {
                    price -= price * 0.20;
                }
            }
            else if (month == "July" || month == "August")
            {
                price = nights * 76.00;
            }
            return price;
        }
    }
}
