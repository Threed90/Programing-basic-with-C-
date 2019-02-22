using System;

namespace BirthDay
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentSand = double.Parse(Console.ReadLine());

            double percentInDouble = percentSand * 0.01;
            

            double totalLiters = length * width * height * 0.001;
            double neededLiters = totalLiters - (totalLiters * percentInDouble);
            Console.WriteLine($"{neededLiters:f3}");
        }
    }
}
