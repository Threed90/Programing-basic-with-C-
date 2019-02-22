using System;

namespace Dance_Hall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthHall = double.Parse(Console.ReadLine())*100;
            double widthHall = double.Parse(Console.ReadLine())*100;
            double wardRobeSide = double.Parse(Console.ReadLine())*100;

            double HallAreaInCM = lengthHall * widthHall;
            double wardrobeAreaInCM = wardRobeSide * wardRobeSide;
            double benchArea = HallAreaInCM / 10;
            double freeSpace = HallAreaInCM - wardrobeAreaInCM - benchArea;

            int NumberOfDancers = (int)(freeSpace / (40 + 7000));

            Console.WriteLine(NumberOfDancers);
        }
    }
}
