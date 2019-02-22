using System;
using System.Collections.Generic;
using System.Linq;

namespace _07.WaterDispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            int volume = int.Parse(Console.ReadLine());

            List<string> button = new List<string>() { "Easy", "Medium", "Hard" };
            List<int> mililiters = new List<int>() { 50, 100, 200 };

            int counter = 0;

            while (true)
            {
                string buttonType = Console.ReadLine();
                volume -= mililiters[button.IndexOf(buttonType)];
                counter++;

                if (volume == 0)
                {
                    Console.WriteLine($"The dispenser has been tapped {counter} times.");
                    break;
                }
                else if (volume < 0)
                {
                    Console.WriteLine($"{Math.Abs(volume)}ml has been spilled.");
                    break;
                }
            }
        }
    }
}
