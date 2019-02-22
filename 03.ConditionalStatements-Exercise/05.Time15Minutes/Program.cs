using System;

namespace _05.Time15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            GetTimePlus15(hours, minutes);
        }

        private static void GetTimePlus15(int hours, int minutes)
        {
            minutes += 15;

            if (minutes > 59)
            {
                hours++;
                minutes %= 60;
            }

            if (hours > 23)
            {
                hours %= 24;
            }

            Console.WriteLine($"{hours}:{minutes:d2}");
        }
    }
}
