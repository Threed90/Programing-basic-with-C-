using System;

namespace _04.SummerOutfit
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = int.Parse(Console.ReadLine());
            string time = Console.ReadLine();

            PrintResult(grade, time);
        }

        private static void PrintResult(int grade, string time)
        {
            bool[] gradeInterval = { 10 <= grade && grade <= 18, 18 < grade && grade <= 24, grade >= 25 };
            string[] timeOfDay = { "Morning", "Afternoon", "Evening" };

            string[] result = new string[3];

            if (gradeInterval[0])
            {
                result = new string[] { "Sweatshirt and Sneakers.",
                                        "Shirt and Moccasins.",
                                        "Shirt and Moccasins." };
            }
            else if (gradeInterval[1])
            {
                result = new string[] {"Shirt and Moccasins.",
                                       "T-Shirt and Sandals.",
                                       "Shirt and Moccasins."};
            }
            else if(gradeInterval[2])
            {
                result = new string[] {"T-Shirt and Sandals.",
                                       "Swim Suit and Barefoot.",
                                       "Shirt and Moccasins."};
            }

            int index = Array.IndexOf(timeOfDay, time);

            Console.WriteLine($"It's {grade} degrees, get your {result[index]}");
        }
    }
}
