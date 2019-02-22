using System;

namespace Number_1_9_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] numbersNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "number too big" };

            if (number > 9)
            {
                Console.WriteLine(numbersNames[10]);
            }
            else
            {
                Console.WriteLine(numbersNames[number]);
            }


        }
    }
}
