using System;

namespace Radiant_to_Degrees
{
    class Program
    {
        static void Main(string[] args)
        {
            double radiants = double.Parse(Console.ReadLine());

            double degrees = radiants * 180/Math.PI;
            Console.WriteLine(Math.Round(degrees));
        }
    }
}
