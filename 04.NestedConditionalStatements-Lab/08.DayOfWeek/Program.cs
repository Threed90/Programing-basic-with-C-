using System;

namespace _08.DayOfWeek
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] days = new string[] { "Error", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            if (number>= 1 && number <= 7)
            {
                Console.WriteLine(days[number]);
            }
            else
            {
                Console.WriteLine(days[0]);
            }
        }
    }
}
