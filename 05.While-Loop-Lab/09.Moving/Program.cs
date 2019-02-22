using System;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int roomVolume = width * length * height;

            while (true)
            {
                string cartons = Console.ReadLine();

                if(cartons == "Done")
                {
                    Console.WriteLine($"{roomVolume} Cubic meters left.");
                    break; ;
                }
                if(roomVolume<0)
                {
                    Console.WriteLine($"No more free space! You need {Math.Abs(roomVolume)} Cubic meters more.");
                    break;
                }

                roomVolume -= int.Parse(cartons);
            }

            
        }
    }
}
