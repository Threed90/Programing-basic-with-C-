using System;

namespace _02.Spaceship
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine());
            double length = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double averageHeight = double.Parse(Console.ReadLine());

            double spaceShipVolume = width * length * height;
            double roomVolume = (averageHeight + 0.40) * 2 * 2;

            int spaceShipPlaces = (int)Math.Floor(spaceShipVolume / roomVolume);

            if(spaceShipPlaces>=3 && spaceShipPlaces<=10)
            {
                Console.WriteLine($"The spacecraft holds {spaceShipPlaces} astronauts.");
            }
            else if(spaceShipPlaces<3)
            {
                Console.WriteLine("The spacecraft is too small.");
            }
            else if(spaceShipPlaces>10)
            {
                Console.WriteLine("The spacecraft is too big.");
            }
        }
    }
}
